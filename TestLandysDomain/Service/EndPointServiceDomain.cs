using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteLandysDomain.Interface;
using TesteLandysDomain.Validations;
using TesteLandysModel.Interface;
using TesteLandysModel.Models;
using TesteLandysRepository.Repository;

namespace TesteLandysDomain.Service
{
    public class EndPointServiceDomain : IEndPointServiceDomain
    {
        private readonly IEndPointRepository _endPointRepository;

        public EndPointServiceDomain()
        {
            _endPointRepository = new EndPointRepository();
        }

        public async Task AddEnPoint(EndPoint endPoint)
        {
            await ValidateEndPoint(endPoint);

            var endPointExist = await _endPointRepository.GetBySerialNumber(endPoint.SerialNumber);
            if (endPointExist is not null)
                throw new Exception("The follow Serial Number inform exist to other EnPoint, you must inform a unique SerialNumber for each EnPoint.");

            await _endPointRepository.AddEnPoint(endPoint);
        }

        public async Task DeleteEndPoint(string serialNumber)
        {
            var endPoint = await GetBySerialNumber(serialNumber);

            await _endPointRepository.DeleteEndPoint(endPoint);
        }

        public Task<List<EndPoint>> GetAllEndPoints()
        {
            return _endPointRepository.GetAllEndPoints();
        }

        public async Task<EndPoint> GetBySerialNumber(string serialNumber)
        {
            var endPoint = await _endPointRepository.GetBySerialNumber(serialNumber);

            if (endPoint is null)
                throw new Exception("EndPoint informed with follow serialNumber does not exist.");

            return endPoint;
        }

        public async Task UpdateEndPoint(EndPoint endPoint)
        {
            await ValidateEndPoint(endPoint);

            var endPointExist = await GetBySerialNumber(endPoint.SerialNumber);

            endPointExist.MeterFirmwareVersion = endPoint.MeterFirmwareVersion;
            endPointExist.MeterNumber = endPoint.MeterNumber;
            endPointExist.ModelId = endPoint.ModelId;
            endPointExist.SerialNumber = endPoint.SerialNumber;
            endPointExist.SwitchState = endPoint.SwitchState;

            await _endPointRepository.UpdateEndPoint(endPointExist);
        }

        private static async Task ValidateEndPoint(EndPoint endPoint)
        {
            var validator = new EndPointValidations();
            var validationResult = await validator.ValidateAsync(endPoint);

            if (!validationResult.IsValid)
            {
                var exceptionMessage = validationResult.Errors.Select(e => e.ErrorMessage).ToArray();
               
                throw new Exception(string.Join("\n",exceptionMessage));
            }
        }
    }
}
