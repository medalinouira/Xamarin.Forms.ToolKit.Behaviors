/// http://www.sweetmit.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.
using System;
using Xamarin.Forms;
using Sample.IViewModels;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace Sample.ViewModels
{
    public class EventToCommandBehaviorViewModel : IEventToCommandBehaviorViewModel
    {
        public ObservableCollection<String> Items
        {
            get
            {
                return new ObservableCollection<String>() { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5" };
            }
        }

        public ICommand SelectedItemCommand { get; set; }

        public EventToCommandBehaviorViewModel()
        {
            SelectedItemCommand = new Command<String>(SelectedItem);
        }

        private void SelectedItem(String param)
        {
            App.Current.MainPage.DisplayAlert("SelectedItem", param, "Ok");
        }
    }
}
