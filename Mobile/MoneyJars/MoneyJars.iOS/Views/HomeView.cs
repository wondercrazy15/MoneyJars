using Foundation;
using MoneyJars.Core.Helper;
using System;
using System.Collections.Generic;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class HomeView : UIViewController
    {
        public HomeView (IntPtr handle) : base (handle)
        {
        }

        public HomeView()
        {
        }

        public override void ViewDidLoad()
        {
            //base.ViewDidLoad();

            SetColors();

            List<string> historyList = new List<string>();
            tblHistory.Source = new HomeHistoryListTableSource(historyList, this);


            List<string> JarsList = new List<string>();
            tblListOfJars.Source = new JarsListTableSource(JarsList, this);

        }

        private void SetColors()
        {
            lblUserName.TextColor = GlobalConst.App_Text_Color;
            lblGreetings.TextColor = GlobalConst.App_Text_Color;

            btnNotification.TintColor = GlobalConst.App_Text_Color;

            lblBalanceTitle.TextColor = GlobalConst.App_Text_Color;
            lblBalanceValue.TextColor = GlobalConst.App_Text_Color;

            lblIncomeTitle.TextColor = GlobalConst.App_Text_Color;
            lblIncomeValue.TextColor = GlobalConst.App_Text_Color;

            lblExpenseTitle.TextColor = GlobalConst.App_Text_Color;
            lblExpenseValue.TextColor = GlobalConst.App_Text_Color;

            lblSeparator1.BackgroundColor = GlobalConst.App_Text_Color;


            lblListOfJarsTitle.TextColor = GlobalConst.App_Text_Color;

            lblSeparator2.BackgroundColor = GlobalConst.App_Text_Color;

            lblHistoryTitle.TextColor = GlobalConst.App_Text_Color;
            lblLatestTransactionTitle.TextColor = GlobalConst.App_Text_Color;

            btnMoreHistory.BackgroundColor = GlobalConst.App_Buttons_Color;
            btnMoreHistory.SetTitleColor(GlobalConst.App_Text_Color, UIControlState.Normal);

            lblSeparator3.BackgroundColor = GlobalConst.App_Text_Color;

            lblHistoryTitle.TextColor = GlobalConst.App_Text_Color;

            btnMoreReports.BackgroundColor = GlobalConst.App_Buttons_Color;
            btnMoreReports.SetTitleColor(GlobalConst.App_Text_Color, UIControlState.Normal);

            viewBG1.BackgroundColor = GlobalConst.App_Primary_Color;
            viewBG2.BackgroundColor = GlobalConst.App_Secondary_Color;
            viewBG3.BackgroundColor = GlobalConst.App_Primary_Color;
            viewBG4.BackgroundColor = GlobalConst.App_Primary_Color;
            viewBG5.BackgroundColor = GlobalConst.App_Primary_Color;
            viewBG6.BackgroundColor = GlobalConst.App_Primary_Color;
            viewBG7.BackgroundColor = GlobalConst.App_Secondary_Color;
            viewBG8.BackgroundColor = GlobalConst.App_Primary_Color;
            viewBG9.BackgroundColor = GlobalConst.App_Secondary_Color;

        }

        internal void UpdateJarListTableHeight(int count)
        {
            constHgtTblJarList.Constant = 70 * count;
        }

        internal void UpdateHistoryTableHeight(int count)
        {
            constHgtTblHistory.Constant = 70 * count;
        }

        public override UIStatusBarStyle PreferredStatusBarStyle()
        {
            return UIStatusBarStyle.LightContent;
        }
    }
}