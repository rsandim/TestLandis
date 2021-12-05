using System.Collections.Generic;
using System.Threading.Tasks;
using TesteLandysModel.Models;

namespace TesteLandysDomain.Interface
{
    public interface IEndPointServiceDomain
    {
        Task AddEnPoint(EndPoint endPoint);

        Task UpdateEndPoint(EndPoint endPoint);

        Task DeleteEndPoint(string serialNumber);

        Task<EndPoint> GetBySerialNumber(string serialNumber);

        Task<List<EndPoint>> GetAllEndPoints();
    }
}
