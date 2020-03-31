using Foundation;
using MoneyJars.Core.ViewModels;
using MoneyJars.iOS.Views;
using System;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class LoginView : BaseView<LoginViewModel>
    {
        public LoginView (IntPtr handle) : base (handle)
        {
        }

        public LoginView()
        {
        }

        public override void ViewDidLoad()
        {
            //base.ViewDidLoad();
        }
    }
}