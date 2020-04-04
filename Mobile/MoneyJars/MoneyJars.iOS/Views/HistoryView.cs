using Foundation;
using MoneyJars.Core.Helper;
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
            viewBG1.BackgroundColor = GlobalConst.App_Primary_Color;
            viewBG2.BackgroundColor = GlobalConst.App_Secondary_Color;


            lblSelectAJarTitle.TextColor = GlobalConst.App_Text_Color;
            lblSelectedJar.TextColor = GlobalConst.App_Text_Color;

            tblHistory.BackgroundColor = GlobalConst.App_Primary_Color;
        }
    }
}