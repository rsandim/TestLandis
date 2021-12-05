namespace TesteLandysModel.Models
{
    public class EndPoint : Base
    {
        public EndPoint()
        {
        }

        public EndPoint(string serialNumber, int modelId, int meterNumber, string meterFirmwareVersion, int switchState)
        {
            SerialNumber = serialNumber;
            ModelId = modelId;
            MeterNumber = meterNumber;
            MeterFirmwareVersion = meterFirmwareVersion;
            SwitchState = switchState;
        }

        public string SerialNumber { get; set; }
        public int ModelId { get; set; }
        public int MeterNumber { get; set; }
        public string MeterFirmwareVersion { get; set; }
        public int SwitchState { get; set; }
    }
}
