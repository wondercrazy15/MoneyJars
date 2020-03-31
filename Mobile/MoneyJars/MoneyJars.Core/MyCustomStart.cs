using System.Threading.Tasks;
using MoneyJars.Core.ViewModels;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MoneyJars.Core
{
    internal class MyCustomStart : MvxAppStart
    {
        IMvxNavigationService _navigationService;
        public MyCustomStart(IMvxApplication application, IMvxNavigationService navigationService) : base(application, navigationService)
        {
            _navigationService = navigationService;
        }

        protected override Task NavigateToFirstViewModel(object hint = null)
        {
            return NavigationService.Navigate<LoginViewModel>();
        }

    }
}