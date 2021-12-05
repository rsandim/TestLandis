using System;
using TesteLandysApplication.ViewModel;
using TesteLandysUI.Handle;
using TesteLandysUI.Interface;
using TesteLandysUI.Models;

namespace TesteLandysUI.UI
{
    public class Menu
    {
        private readonly IEndPointUI _endPointUI;

        public Menu()
        {
            _endPointUI = new EndPointUI();
        }

        public async void ShowMenu()
        {
            bool mustContinue;
            EndPointViewModel endPointViewModel;
            string serialNumber;

            do
            {
                MenuOptions.ShowMenuOptions();
                var value = Console.ReadLine();
                mustContinue = (value != MenuOptions.Exit);
                switch (value) 
                {
                    case MenuOptions.InsertEndPoint:
                        endPointViewModel = EndPointViewModelFactory.BuildEndPointViewModel();
                        await _endPointUI.AddEnPoint(endPointViewModel); 
                        break;
                    case MenuOptions.EditEndPoint:
                        endPointViewModel = EndPointViewModelFactory.BuildEndPointViewModel();
                        await _endPointUI.UpdateEndPoint(endPointViewModel);
                        break;
                    case MenuOptions.DeleteEndPoint:
                        serialNumber = EndPointViewModelFactory.GetSerialNumber();
                        await _endPointUI.DeleteEndPoint(serialNumber);
                        break;
                    case MenuOptions.ListAllEndPoints:
                        var endPointsViewModel = await _endPointUI.GetAllEndPoints();
                        PrintEndPointViewModel.PrintEndPointsViewModelOnScreen(endPointsViewModel);
                        break;
                    case MenuOptions.FindEndPoint:
                        serialNumber = EndPointViewModelFactory.GetSerialNumber();                     
                        PrintEndPointViewModel.PrintEndPointViewModelOnScreen(await _endPointUI.GetBySerialNumber(serialNumber));
                        break;
                    case MenuOptions.Exit:
                        Console.WriteLine("Exit Programn.");
                        break;
                    default:
                        Console.WriteLine("Wrong option.");
                        break;
                }

            } while(mustContinue);
        }
    }
}
