using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.Core.ViewModels;
using MoneyJars.iOS.Helper;
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
            viewExtraSpace.BackgroundColor = Constants.App_Extra_Space_Color;

            viewMain.BackgroundColor = Constants.App_Primary_Color;

            btnBack.TintColor = Constants.App_Text_Color;
            lblInformationTitle.TextColor = Constants.App_Text_Color;

            imgAppIcon.Layer.CornerRadius = imgAppIcon.Frame.Size.Height / 2;
            imgAppIcon.ClipsToBounds = true;
            imgAppIcon.BackgroundColor = Constants.App_Buttons_Color;


            lblAppName.TextColor = Constants.App_Text_Color;
            lblVersion.TextColor = Constants.App_Text_Color;
            lblDevice.TextColor = Constants.App_Text_Color;
            lblUserId.TextColor = Constants.App_Text_Color;


        }

        partial void btnBackClicked(UIButton sender)
        {
            NavigationController.PopViewController(true);
        }
    }
}