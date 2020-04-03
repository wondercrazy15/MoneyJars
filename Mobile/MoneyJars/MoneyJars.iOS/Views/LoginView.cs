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

        public override UIStatusBarStyle PreferredStatusBarStyle()
        {
            return UIStatusBarStyle.LightContent;
        }

        partial void btnLoginWithGoggleClicked(UIButton sender)
        {
            
        }

        partial void btnLoginWithFacebookClicked(UIButton sender)
        {
            WalkThroughView vc = Storyboard.InstantiateViewController("WalkThroughView") as WalkThroughView;
            NavigationController.PushViewController(vc, true);
        }
    }
}