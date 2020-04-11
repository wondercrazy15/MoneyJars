using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.iOS.Helper;
using System;
using System.Collections.Generic;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class HistoryView : UIViewController
    {
        public HistoryView (IntPtr handle) : base (handle)
        {
        }

        public HistoryView()
        {
        }

        public override void ViewDidLoad()
        {

            SetColors();

            List<string> historyList = new List<string>();
            tblHistory.Source = new HistoryListTableSource(historyList, this);
        }


        public override UIStatusBarStyle PreferredStatusBarStyle()
        {
            return UIStatusBarStyle.LightContent;
        }

        private void SetColors()
        {
            viewExtraSpace.BackgroundColor = Constants.App_Extra_Space_Color;

            viewBG1.BackgroundColor = Constants.App_Primary_Color;
            viewBG2.BackgroundColor = Constants.App_Secondary_Color;

            lblSelectAJarTitle.TextColor = Constants.App_Text_Color;
            lblSelectedJar.TextColor = Constants.App_Text_Color;

            tblHistory.BackgroundColor = Constants.App_Primary_Color;
        }
    }
}