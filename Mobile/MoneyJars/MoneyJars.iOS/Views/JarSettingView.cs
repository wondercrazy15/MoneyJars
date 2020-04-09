using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.Core.ViewModels;
using MoneyJars.iOS.Views;
using System;
using System.Collections.Generic;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class JarSettingView : BaseView<JarSettingViewModel>
    {
        public JarSettingView (IntPtr handle) : base (handle)
        {
        }

        public JarSettingView()
        {
        }

        public override void ViewDidLoad()
        {
            SetColors();

            List<string> jarList = new List<string>();
            tblJarSettings.Source = new JarSettingListTableSource(jarList, this);

        }

        public override UIStatusBarStyle PreferredStatusBarStyle()
        {
            return UIStatusBarStyle.LightContent;
        }

        private void SetColors()
        {
            viewExtraSpace.BackgroundColor = GlobalConst.App_Extra_Space_Color;
            viewMain.BackgroundColor = GlobalConst.App_Primary_Color;

            tblJarSettings.BackgroundColor = GlobalConst.App_Primary_Color;

            btnBack.TintColor = GlobalConst.App_Text_Color;
            lblJarSettingTitle.TextColor = GlobalConst.App_Text_Color;
            btnSave.SetTitleColor(GlobalConst.App_Buttons_Color, UIControlState.Normal);

            lblPieChartHere.TextColor = GlobalConst.App_Text_Color;

        }

        partial void btnBackClicked(UIButton sender)
        {
            NavigationController.PopViewController(true);
        }
    }
}