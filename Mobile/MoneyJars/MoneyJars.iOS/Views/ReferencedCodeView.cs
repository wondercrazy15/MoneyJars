using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.Core.ViewModels;
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
            viewExtraSpace.BackgroundColor = GlobalConst.App_Extra_Space_Color;
            viewMainBG.BackgroundColor = GlobalConst.App_Primary_Color;

            btnBack.TintColor = GlobalConst.App_Text_Color;

            lblReferenceCodeTitle.TextColor = GlobalConst.App_Text_Color;
            lblReferenceCodeMessage.TextColor = GlobalConst.App_Text_Color;

            lblEnterCodeTitle.TextColor = GlobalConst.App_Text_Color;
            txtReferenceCode.TextColor = GlobalConst.App_Buttons_Color;
            txtReferenceCode.TintColor = GlobalConst.App_Buttons_Color;
            txtReferenceCode.BackgroundColor = GlobalConst.App_Text_Color;

            btnSubmit.SetTitleColor(GlobalConst.App_Text_Color, UIControlState.Normal);
            btnSubmit.BackgroundColor = GlobalConst.App_Buttons_Color;
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