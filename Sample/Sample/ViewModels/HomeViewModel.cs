/// http://www.sweetmit.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.
using System;
using Xamarin.Forms;
using Sample.IViewModels;
using System.Windows.Input;
using Xamarin.Forms.Navigation;

namespace Sample.ViewModels
{
    public class HomeViewModel : IHomeViewModel
    {
        private INavigationService _iNavigationService;

        public ICommand BtnTappedCommand { get; set; }

        public HomeViewModel()
        {
            _iNavigationService = DependencyService.Get<INavigationService>(DependencyFetchTarget.GlobalInstance);
            BtnTappedCommand = new Command<String>(BtnTapped);
        }

        private async void BtnTapped(string param)
        {
            switch (param)
            {
                case "EventToCommand":
                    await _iNavigationService.NavigateTo("EventToCommandBehaviorView");
                    break;
                default:
                    break;
            }
        }
    }
}
