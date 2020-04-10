using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.Core.ViewModels;
using MoneyJars.iOS.Views;
using System;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class InformationView : BaseView<InformationViewModel>
    {
        public InformationView (IntPtr handle) : base (handle)
        {
        }

        public InformationView()
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

            viewMain.BackgroundColor = GlobalConst.App_Primary_Color;


            btnBack.TintColor = GlobalConst.App_Text_Color;
            lblInformationTitle.TextColor = GlobalConst.App_Text_Color;

            imgAppIcon.Layer.CornerRadius = imgAppIcon.Frame.Size.Height / 2;
            imgAppIcon.ClipsToBounds = true;

            lblAppName.TextColor = GlobalConst.App_Text_Color;
            lblVersion.TextColor = GlobalConst.App_Text_Color;
            lblDevice.TextColor = GlobalConst.App_Text_Color;
            lblUserId.TextColor = GlobalConst.App_Text_Color;


        }

        partial void btnBackClicked(UIButton sender)
        {
            NavigationController.PopViewController(true);
        }
    }
}