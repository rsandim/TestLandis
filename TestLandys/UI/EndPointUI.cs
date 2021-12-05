using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteLandysApplication.Interface;
using TesteLandysApplication.Service;
using TesteLandysApplication.ViewModel;
using TesteLandysUI.Interface;

namespace TesteLandysUI.UI
{
    public class EndPointUI : IEndPointUI
    {
        private IEndPointServiceApplication _endPointServiceApplication;

        public EndPointUI()
        {
            _endPointServiceApplication = new EndPointServiceApplication();
        }

        public async Task AddEnPoint(EndPointViewModel endPointViewModel)
        {
            try
            {
                await _endPointServiceApplication.AddEnPoint(endPointViewModel);
                Console.WriteLine("EndPoint inserted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString()); 
            }          
        }

        public async Task DeleteEndPoint(string serialNumber)
        {
            try
            {
                await _endPointServiceApplication.DeleteEndPoint(serialNumber);
                Console.WriteLine("EndPoint deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public async Task<List<EndPointViewModel>> GetAllEndPoints()
        {
            var endPointsViewModel = new List<EndPointViewModel>();
            try
            {
                endPointsViewModel = await _endPointServiceApplication.GetAllEndPoints();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            
            return endPointsViewModel;
        }

        public async Task<EndPointViewModel> GetBySerialNumber(string serialNumber)
        {
            EndPointViewModel endPointViewModel = null;
            try
            {
                endPointViewModel = await _endPointServiceApplication.GetBySerialNumber(serialNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return endPointViewModel;
        }

        public async Task UpdateEndPoint(EndPointViewModel endPointViewModel)
        {
            try
            {
                await _endPointServiceApplication.UpdateEndPoint(endPointViewModel);
                Console.WriteLine("EndPoint updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }    
    }
}
