using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.Core.ViewModels;
using MoneyJars.iOS.Helper;
using MoneyJars.iOS.Views;
using System;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class MyReferenceCodeView : BaseView<MyReferenceCodeViewModel>
    {
        public MyReferenceCodeView (IntPtr handle) : base (handle)
        {
        }

        public MyReferenceCodeView()
        {
        }

        public override void ViewDidLoad()
        {
            SetColors();
        }

        public override UIStatusBarStyle PreferredStatusBarStyle()
        {
            return UIStatusBarStyle.LightContent;
        }

        private void SetColors()
        {
            viewExtraSpace.BackgroundColor = Constants.App_Extra_Space_Color;
            viewMainBG.BackgroundColor = Constants.App_Primary_Color;

            viewBG1.BackgroundColor = Constants.App_Secondary_Color;

            lblReferenceCodeTitle.TextColor = Constants.App_Text_Color;
            lblReferenceCodeValue.TextColor = Constants.App_Text_Color;
            btnShare.SetTitleColor(Constants.App_Buttons_Color, UIControlState.Normal);

            lblThanksForReferMessage.TextColor = Constants.App_Text_Color;
            lblNoData.TextColor = Constants.App_Text_Color;
            btnRetry.SetTitleColor(Constants.App_Primary_Color, UIControlState.Normal);

        }

        partial void btnBackClicked(UIButton sender)
        {
            NavigationController.PopViewController(true);
        }
    }
}