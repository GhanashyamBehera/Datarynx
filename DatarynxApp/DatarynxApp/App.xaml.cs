using Prism;
using Prism.Ioc;
using DatarynxApp.ViewModels;
using DatarynxApp.Views;
using Xamarin.Essentials.Interfaces;
using Xamarin.Essentials.Implementation;
using Xamarin.Forms;
using DatarynxApp.Views.MasterDetails;

[assembly: ExportFont("Montserrat-Bold.ttf", Alias = "MontserratBoldFont")]
[assembly: ExportFont("Montserrat-SemiBold.ttf", Alias = "MontserratSemiBoldFont")]
[assembly: ExportFont("Montserrat-Regular.ttf", Alias = "MontserratRegularFont")]
[assembly: ExportFont("Montserrat-Light.ttf", Alias = "MontserratLightFont")]
namespace DatarynxApp
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            //await NavigationService.NavigateAsync("NavigationPage/MainPage");
            await NavigationService.NavigateAsync("/" + nameof(PrismMasterDetailPage) + "/" + nameof(NavigationPage) + "/" + nameof(DatarynxApp.Views.MainPage));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<PrismMasterDetailPage, PrismMasterDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<AboutPage, AboutPageViewModel>();
        }
    }
}
