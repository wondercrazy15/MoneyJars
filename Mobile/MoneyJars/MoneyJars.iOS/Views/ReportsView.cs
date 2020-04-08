using Foundation;
using MoneyJars.Core.Helper;
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
            viewExtraSpace.BackgroundColor = GlobalConst.App_Extra_Space_Color;

            viewBG1.BackgroundColor = GlobalConst.App_Primary_Color;
            viewBG2.BackgroundColor = GlobalConst.App_Primary_Color;

            viewBG3.BackgroundColor = GlobalConst.App_Secondary_Color;
            viewBG4.BackgroundColor = GlobalConst.App_Secondary_Color;

            lblSelectJarTitle.TextColor = GlobalConst.App_Text_Color;
            lblSelectedJar.TextColor = GlobalConst.App_Text_Color;
            imgArrowDown.TintColor = GlobalConst.App_Text_Color;

            lblSelectedDate.TextColor = GlobalConst.App_Text_Color;
            imgSelectDateArrow.TintColor = GlobalConst.App_Text_Color;

            btnMonth.SetTitleColor(GlobalConst.App_Text_Color, UIControlState.Normal);
            btnLifeTime.SetTitleColor(GlobalConst.App_Text_Color, UIControlState.Normal);

            lblNoData.TextColor = GlobalConst.App_Text_Color;

            btnMoreReports.BackgroundColor = GlobalConst.App_Buttons_Color;
            btnMoreReports.SetTitleColor(GlobalConst.App_Text_Color, UIControlState.Normal);

            viewSwapButton.BackgroundColor = GlobalConst.App_Extra_Space_Color;
            viewSwapButton.Layer.BorderColor = GlobalConst.App_Secondary_Color.CGColor;
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