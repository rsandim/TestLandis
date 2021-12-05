using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteLandysApplication.Factory;
using TesteLandysApplication.Interface;
using TesteLandysApplication.ViewModel;
using TesteLandysDomain.Interface;
using TesteLandysDomain.Service;

namespace TesteLandysApplication.Service
{
    public class EndPointServiceApplication : IEndPointServiceApplication
    {
        public readonly IEndPointServiceDomain _endPointServiceDomain;
        public readonly IEndPointFactory _endPointFactory;

        public EndPointServiceApplication()
        {
            _endPointServiceDomain = new EndPointServiceDomain();
            _endPointFactory = new EndPointFactory();
        }

        public async Task AddEnPoint(EndPointViewModel endPointViewModel)
        {
            var endPoint = _endPointFactory.EndPointViewModelToEndPoint(endPointViewModel);
            await _endPointServiceDomain.AddEnPoint(endPoint);
        }

        public async Task DeleteEndPoint(string serialNumber)
        {
            await _endPointServiceDomain.DeleteEndPoint(serialNumber);
        }

        public async Task<List<EndPointViewModel>> GetAllEndPoints()
        {
            var endPoints = await _endPointServiceDomain.GetAllEndPoints();
            var endPointsViewModel = new List<EndPointViewModel>();
            foreach (var endpPoint in endPoints)
            {
                try
                {
                    var endPointViewModel = _endPointFactory.EndPointToEndPointViewModel(endpPoint);
                    endPointsViewModel.Add(endPointViewModel);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return endPointsViewModel;
        }

        public async Task<EndPointViewModel> GetBySerialNumber(string serialNumber)
        {
            var endPoint = await _endPointServiceDomain.GetBySerialNumber(serialNumber);
            return _endPointFactory.EndPointToEndPointViewModel(endPoint);
        }

        public async Task UpdateEndPoint(EndPointViewModel endPointViewModel)
        {
            var endPoint = _endPointFactory.EndPointViewModelToEndPoint(endPointViewModel);
            await _endPointServiceDomain.UpdateEndPoint(endPoint);
        }
    }
}
