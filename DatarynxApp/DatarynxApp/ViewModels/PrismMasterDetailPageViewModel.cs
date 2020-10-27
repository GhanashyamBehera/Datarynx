using DatarynxApp.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatarynxApp.ViewModels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class PrismMasterDetailPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;
        public DelegateCommand NavigateCommand { get; private set; }

        public ObservableCollection<MyMenuItem> MenuItems { get; set; }


        public PrismMasterDetailPageViewModel(INavigationService navigationService): base(navigationService)
        {
            this._navigationService = navigationService;
            MenuItems = new ObservableCollection<MyMenuItem>();

            MenuItems.Add(new MyMenuItem()
            {
                Icon = "home.png",
                PageName = nameof(MainPage),
                Title = "Home"
            });

            MenuItems.Add(new MyMenuItem()
            {
                Icon = "information.png",
                PageName = nameof(AboutPage),
                Title = "About"
            });
            MenuItems.Add(new MyMenuItem()
            {
                Icon = "logout.png",
                PageName = nameof(AboutPage),
                Title = "Logout"
            });

            NavigateCommand = new DelegateCommand(Navigate);
        }

        private MyMenuItem selectedMenuItem;

        public MyMenuItem SelectedMenuItem
        {
            get => selectedMenuItem;
            set => SetProperty(ref selectedMenuItem, value);
        }

        private async void Navigate()
        {
            await _navigationService.NavigateAsync(nameof(NavigationPage) + "/" + SelectedMenuItem.PageName);
        }
    }

    public class MyMenuItem
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public string PageName { get; set; }
    }
}
