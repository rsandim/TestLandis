using System.Collections.Generic;
using System.Threading.Tasks;
using TesteLandysModel.Models;

namespace TesteLandysModel.Interface
{
    public interface IEndPointRepository
    {
        Task AddEnPoint(EndPoint endPoint);
        Task UpdateEndPoint(EndPoint endPointExist);
        Task DeleteEndPoint(EndPoint endPoint);
        Task<EndPoint> GetBySerialNumber(string serialNumber);
        Task<List<EndPoint>> GetAllEndPoints();        
    }
}
