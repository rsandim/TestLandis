using System;
using TesteLandysApplication.ViewModel;

namespace TesteLandysUI.Handle
{
    public static class EndPointViewModelFactory
    {
        public static EndPointViewModel BuildEndPointViewModel()
        {
            var serialNumber = GetSerialNumber();
            Console.WriteLine("Inform Model Identifier:");
            var modelId = Console.ReadLine();
            Console.WriteLine("Inform Meter Number:");
            var meterNumber = Console.ReadLine();
            Console.WriteLine("Inform Meter Firmware Version:");
            var meterFirmwareVersion = Console.ReadLine();
            Console.WriteLine("Inform SwitchState:");
            var switchState = Console.ReadLine();

            return new EndPointViewModel(serialNumber, modelId, meterNumber, meterFirmwareVersion, switchState);
        }

        public static string GetSerialNumber()
        {
            Console.WriteLine("Inform Serial Number:");
            return Console.ReadLine();
        }
    }
}
