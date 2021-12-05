using System;
using System.Collections.Generic;
using System.Linq;
using TesteLandysApplication.ViewModel;

namespace TesteLandysUI.UI
{
    public static class PrintEndPointViewModel
    {
        public static void PrintEndPointsViewModelOnScreen(List<EndPointViewModel> endPointsViewModel)
        {
            if (endPointsViewModel is null || !endPointsViewModel.Any())
            {
                Console.WriteLine("There is no EndPoint recorded.");
                return;
            }
            
            foreach (var endPointViewModel in endPointsViewModel)
            {
                PrintEndPointViewModelOnScreen(endPointViewModel);
            }
        }

        public static void PrintEndPointViewModelOnScreen(EndPointViewModel endPointsViewModel)
        {
            if (endPointsViewModel is null)
            {
                return;
            }

           Console.WriteLine(endPointsViewModel.ToString());            
        }

    }
}
