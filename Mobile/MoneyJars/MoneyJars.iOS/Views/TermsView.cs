using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.Core.ViewModels;
using MoneyJars.iOS.Views;
using System;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class TermsView : BaseView<TermsViewModel>, IUIWebViewDelegate
    {
        public TermsView (IntPtr handle) : base (handle)
        {
        }

        public TermsView()
        {
        }

        public override void ViewDidLoad()
        {
            SetColors();

            LoadTermsUrl();
        }

        public override UIStatusBarStyle PreferredStatusBarStyle()
        {
            return UIStatusBarStyle.LightContent;
        }

        private void LoadTermsUrl()
        {
            webViewTerms.Delegate = this;
            webViewTerms.LoadRequest(new NSUrlRequest(new NSUrl(GlobalConst.TermsUrl)));

        }

        private void SetColors()
        {
            viewExtraSpace.BackgroundColor = GlobalConst.App_Extra_Space_Color;

            viewMain.BackgroundColor = GlobalConst.App_Primary_Color;

        }


        [Export("webViewDidStartLoad:")]
        public void LoadStarted(UIWebView webView)
        {
            webViewLoader.StartAnimating();
            webViewLoader.Hidden = false;
        }

        [Export("webViewDidFinishLoad:")]
        public void LoadingFinished(UIWebView webView)
        {
            webViewLoader.StopAnimating();
            webViewLoader.Hidden = true;
        }

        partial void btnBackClicked(UIButton sender)
        {
            NavigationController.PopViewController(true);
        }
    }
}