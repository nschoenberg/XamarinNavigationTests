using System;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using XamarinNavigationTests.Infrastructure;

namespace XamarinNavigationTests.ViewModels
{
    public class GoodsInViewModel : AppMapViewModelBase
    {


        public GoodsInViewModel(INavigationService navigationService) : base (navigationService)
        {
        }
    }
}
