using TesteLandysApplication.ViewModel;
using TesteLandysModel.Models;

namespace TesteLandysApplication.Interface
{
    public interface IEndPointFactory
    {
        public EndPoint EndPointViewModelToEndPoint(EndPointViewModel endPointViewModel);

        public EndPointViewModel EndPointToEndPointViewModel(EndPoint endPoint);
    }
}
