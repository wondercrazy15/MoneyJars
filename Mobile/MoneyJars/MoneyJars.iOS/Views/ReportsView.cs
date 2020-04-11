using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.iOS.Helper;
using System;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class ReportsView : UIViewController
    {
        public ReportsView (IntPtr handle) : base (handle)
        {
        }

        public ReportsView()
        {
        }

        public override void ViewDidLoad()
        {
            SetColors();
        }

        private void SetColors()
        {
            viewExtraSpace.BackgroundColor = Constants.App_Extra_Space_Color;

            viewBG1.BackgroundColor = Constants.App_Primary_Color;
            viewBG2.BackgroundColor = Constants.App_Primary_Color;

            viewBG3.BackgroundColor = Constants.App_Secondary_Color;
            viewBG4.BackgroundColor = Constants.App_Secondary_Color;

            lblSelectJarTitle.TextColor = Constants.App_Text_Color;
            lblSelectedJar.TextColor = Constants.App_Text_Color;
            imgArrowDown.TintColor = Constants.App_Text_Color;

            lblSelectedDate.TextColor = Constants.App_Text_Color;
            imgSelectDateArrow.TintColor = Constants.App_Text_Color;

            btnMonth.SetTitleColor(Constants.App_Text_Color, UIControlState.Normal);
            btnLifeTime.SetTitleColor(Constants.App_Text_Color, UIControlState.Normal);

            lblNoData.TextColor = Constants.App_Text_Color;

            btnMoreReports.BackgroundColor = Constants.App_Buttons_Color;
            btnMoreReports.SetTitleColor(Constants.App_Text_Color, UIControlState.Normal);

            viewSwapButton.BackgroundColor = Constants.App_Extra_Space_Color;
            viewSwapButton.Layer.BorderColor = Constants.App_Secondary_Color.CGColor;
            viewSwapButton.Layer.BorderWidth = 1.5f;
        }

        public override UIStatusBarStyle PreferredStatusBarStyle()
        {
            return UIStatusBarStyle.LightContent;
        }

        partial void btnMonthClicked(UIButton sender)
        {
            btnMonth.BackgroundColor = UIColor.SystemGreenColor;
            btnLifeTime.BackgroundColor = UIColor.Clear;
        }

        partial void btnLifeTimeClicked(UIButton sender)
        {
            btnMonth.BackgroundColor = UIColor.Clear;
            btnLifeTime.BackgroundColor = UIColor.SystemGreenColor;
        }
    }
}