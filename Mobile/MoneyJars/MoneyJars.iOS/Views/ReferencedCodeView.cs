using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.Core.ViewModels;
using MoneyJars.iOS.Helper;
using MoneyJars.iOS.Views;
using System;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class ReferencedCodeView : BaseView<ReferencedCodeViewModel>
    {
        public ReferencedCodeView (IntPtr handle) : base (handle)
        {
        }

        public ReferencedCodeView()
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

            btnBack.TintColor = Constants.App_Text_Color;

            lblReferenceCodeTitle.TextColor = Constants.App_Text_Color;
            lblReferenceCodeMessage.TextColor = Constants.App_Text_Color;

            lblEnterCodeTitle.TextColor = Constants.App_Text_Color;
            txtReferenceCode.TextColor = Constants.App_Buttons_Color;
            txtReferenceCode.TintColor = Constants.App_Buttons_Color;
            txtReferenceCode.BackgroundColor = Constants.App_Text_Color;

            btnSubmit.SetTitleColor(Constants.App_Text_Color, UIControlState.Normal);
            btnSubmit.BackgroundColor = Constants.App_Buttons_Color;
        }

        partial void btnBackClicked(UIButton sender)
        {
            NavigationController.PopViewController(true);
        }

        partial void btnSubmitClicked(UIButton sender)
        {
            
        }
    }
}