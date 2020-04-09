using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.Core.ViewModels;
using MoneyJars.iOS.Views;
using System;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class FAQsView : BaseView<FAQsViewModel>, IUIWebViewDelegate
    {

        public FAQsView (IntPtr handle) : base (handle)
        {
        }

        public FAQsView()
        {
        }

        public override void ViewDidLoad()
        {
            SetColors();

            LoadFAQsUrl();
        }

        private void LoadFAQsUrl()
        {
            webViewFAQs.Delegate = this;
            webViewFAQs.LoadRequest(new NSUrlRequest(new NSUrl(GlobalConst.FAQsUrl)));
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

        public override UIStatusBarStyle PreferredStatusBarStyle()
        {
            return UIStatusBarStyle.LightContent;
        }

        private void SetColors()
        {
            viewExtraSpace.BackgroundColor = GlobalConst.App_Extra_Space_Color;
            viewMainBG.BackgroundColor = GlobalConst.App_Primary_Color;

            btnBack.TintColor = GlobalConst.App_Text_Color;
            lblFAQsTitle.TextColor = GlobalConst.App_Text_Color;

        }

        partial void btnBackClicked(UIButton sender)
        {
            NavigationController.PopViewController(true);
        }
    }
}