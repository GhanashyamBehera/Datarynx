using DatarynxApp.Interfaces;
using DatarynxApp.ViewModels;

namespace DatarynxApp.Views
{
    public partial class MainPage
    {
        private MainPageViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            viewModel = (MainPageViewModel)BindingContext;
            viewModel?.GetSqliteDB();
            base.OnAppearing();

        }
    }
}
