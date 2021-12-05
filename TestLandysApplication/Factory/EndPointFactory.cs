using System;
using TesteLandysApplication.Interface;
using TesteLandysApplication.ViewModel;
using TesteLandysModel.Enums;
using TesteLandysModel.Models;

namespace TesteLandysApplication.Factory
{
    public class EndPointFactory : IEndPointFactory
    {
        public EndPointViewModel EndPointToEndPointViewModel(EndPoint endPoint)
        {
            return new EndPointViewModel(endPoint.SerialNumber,
                Enum.GetName((ModelType)endPoint.ModelId),
                endPoint.MeterNumber.ToString(),
                endPoint.MeterFirmwareVersion, 
                Enum.GetName((SwitchState)endPoint.SwitchState));
        }

        public EndPoint EndPointViewModelToEndPoint(EndPointViewModel endPointViewModel)
        {
            var modelId = ParseModelType(endPointViewModel.ModelId);
            var swichMode = ParseSwitchState(endPointViewModel.SwitchState);
            var meterNumber = ParseMeterNumber(endPointViewModel.MeterNumber);

            return new EndPoint(endPointViewModel.SerialNumber, 
                modelId, 
                meterNumber, 
                endPointViewModel.MeterFirmwareVersion, 
                swichMode);
        }

        private static int ParseModelType(string modelId)
        {
            if (modelId == Enum.GetName(ModelType.NSX1P2W))
                return (int)ModelType.NSX1P2W;
            else if (modelId == Enum.GetName(ModelType.NSX1P3W))
                return (int)ModelType.NSX1P3W;
            else if (modelId == Enum.GetName(ModelType.NSX2P3W))
                return (int)ModelType.NSX2P3W;
            else if (modelId == Enum.GetName(ModelType.NSX3P4W))
                return (int)ModelType.NSX3P4W;
            else return 0;
        }
        private static int ParseSwitchState(string switchState)
        {
            if (switchState == Enum.GetName(SwitchState.Disconnected))
                return (int)SwitchState.Disconnected;
            else if (switchState == Enum.GetName(SwitchState.Connected))
                return (int)SwitchState.Connected;
            else if (switchState == Enum.GetName(SwitchState.Armed))
                return (int)SwitchState.Armed;
            else return -1;
        }
        private static int ParseMeterNumber(string meterNumber)
        {
            if (!int.TryParse(meterNumber, out int result))
                return default;

            return result;
        }

    }
}
