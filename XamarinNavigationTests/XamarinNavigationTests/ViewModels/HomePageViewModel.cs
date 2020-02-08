using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using XamarinNavigationTests.Infrastructure;

namespace XamarinNavigationTests.ViewModels
{
    public class HomePageViewModel : AppMapViewModelBase
    {


        public HomePageViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
