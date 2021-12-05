namespace TesteLandysApplication.ViewModel
{
    public class EndPointViewModel
    {
        public EndPointViewModel()
        {
        }

        public EndPointViewModel(string serialNumber, string modelId, string meterNumber, string meterFirmwareVersion, string switchState)
        {
            SerialNumber = serialNumber;
            ModelId = modelId;
            MeterNumber = meterNumber;
            MeterFirmwareVersion = meterFirmwareVersion;
            SwitchState = switchState;
        }

        public string ModelId { get; set; }
        public string SerialNumber { get; set; }
        public string MeterNumber { get; set; }
        public string MeterFirmwareVersion { get; set; }
        public string SwitchState { get; set; }

        public override string ToString()
        {
            return $" ModelId: { ModelId} \n"+
                   $" SerialNumber: {SerialNumber} \n"+
                   $" MeterNumber: {MeterNumber} \n"+
                   $" MeterFirmwareVersion: {MeterFirmwareVersion}\n" +
                   $" SwitchState: {SwitchState} \n";
        }
    }
}
