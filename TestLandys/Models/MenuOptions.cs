using System;

namespace TesteLandysUI.Models
{
    public static class MenuOptions
    {
        public const string InsertEndPoint = "1";
        public const string EditEndPoint = "2";
        public const string DeleteEndPoint = "3";
        public const string ListAllEndPoints = "4";
        public const string FindEndPoint = "5";
        public const string Exit = "6";

        public static void ShowMenuOptions() 
        {
            Console.WriteLine("Choose among the follow options:");
            Console.WriteLine($"{InsertEndPoint} - InsertEndPoint");
            Console.WriteLine($"{EditEndPoint} - EditEndPoint");
            Console.WriteLine($"{DeleteEndPoint} - DeleteEndPoint");
            Console.WriteLine($"{ListAllEndPoints} - ListAllEndPoints");
            Console.WriteLine($"{FindEndPoint} - FindEndPoint");
            Console.WriteLine($"{Exit} - Exit");        }
    }
}
