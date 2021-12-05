using System.Collections.Generic;
using System.Threading.Tasks;
using TesteLandysApplication.ViewModel;

namespace TesteLandysUI.Interface
{
    public interface IEndPointUI
    {
        Task AddEnPoint(EndPointViewModel endPointViewModel);

        Task UpdateEndPoint(EndPointViewModel endPointViewModel);

        Task DeleteEndPoint(string serialNumber);

        Task<EndPointViewModel> GetBySerialNumber(string serialNumber);

        Task<List<EndPointViewModel>> GetAllEndPoints();
    }
}
