using System.Collections.Generic;
using System.Threading.Tasks;
using TesteLandysApplication.ViewModel;

namespace TesteLandysApplication.Interface
{
    public interface IEndPointServiceApplication
    {
        Task AddEnPoint(EndPointViewModel endPointViewModel);

        Task UpdateEndPoint(EndPointViewModel endPointViewModel);

        Task DeleteEndPoint(string serialNumber);

        Task<EndPointViewModel> GetBySerialNumber(string serialNumber);

        Task<List<EndPointViewModel>> GetAllEndPoints();
    }
}
