using Prism;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinNavigationTests.Views;
using XamarinNavigationTests.ViewModels;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinNavigationTests
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("NavigationPage/LoginPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<GoodsIn, GoodsInViewModel>();
            containerRegistry.RegisterForNavigation<GoodsInMaster, GoodsInMasterViewModel>();
            containerRegistry.RegisterForNavigation<GoodsInDetail, GoodsInDetailViewModel>();
            containerRegistry.RegisterForNavigation<GoodsInDetailTwo, GoodsInDetailTwoViewModel>();
            containerRegistry.RegisterForNavigation<CustomerSearchPage, CustomerSearchPageViewModel>();
            containerRegistry.RegisterForNavigation<CustomerOverviewPage, CustomerOverviewPageViewModel>();
            containerRegistry.RegisterForNavigation<CustomerAddressPage, CustomerAddressPageViewModel>();
            containerRegistry.RegisterForNavigation<CustomerCardPage, CustomerCardPageViewModel>();
        }
    }
}
