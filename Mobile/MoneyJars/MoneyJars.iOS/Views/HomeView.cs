using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.iOS.Helper;
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
            viewExtraSpace.BackgroundColor = Constants.App_Extra_Space_Color;

            lblUserName.TextColor = Constants.App_Text_Color;
            lblGreetings.TextColor = Constants.App_Text_Color;

            btnNotification.TintColor = Constants.App_Text_Color;

            btnIncomeImage.TintColor = Constants.App_Green_Color;
            btnExpenseImage.TintColor = Constants.App_Red_Color;

            lblBalanceTitle.TextColor = Constants.App_Text_Color;
            lblBalanceValue.TextColor = Constants.App_Text_Color;

            lblIncomeTitle.TextColor = Constants.App_Text_Color;
            lblIncomeValue.TextColor = Constants.App_Text_Color;

            lblExpenseTitle.TextColor = Constants.App_Text_Color;
            lblExpenseValue.TextColor = Constants.App_Text_Color;

            lblSeparator1.BackgroundColor = Constants.App_Text_Color;


            lblListOfJarsTitle.TextColor = Constants.App_Text_Color;

            lblSeparator2.BackgroundColor = Constants.App_Text_Color;

            lblHistoryTitle.TextColor = Constants.App_Text_Color;
            lblLatestTransactionTitle.TextColor = Constants.App_Text_Color;

            btnMoreHistory.BackgroundColor = Constants.App_Buttons_Color;
            btnMoreHistory.SetTitleColor(Constants.App_Text_Color, UIControlState.Normal);

            lblSeparator3.BackgroundColor = Constants.App_Text_Color;

            lblHistoryTitle.TextColor = Constants.App_Text_Color;

            btnMoreReports.BackgroundColor = Constants.App_Buttons_Color;
            btnMoreReports.SetTitleColor(Constants.App_Text_Color, UIControlState.Normal);

            viewBG1.BackgroundColor = Constants.App_Primary_Color;
            viewBG2.BackgroundColor = Constants.App_Secondary_Color;
            viewBG3.BackgroundColor = Constants.App_Primary_Color;
            viewBG4.BackgroundColor = Constants.App_Primary_Color;
            viewBG5.BackgroundColor = Constants.App_Primary_Color;
            viewBG6.BackgroundColor = Constants.App_Primary_Color;
            viewBG7.BackgroundColor = Constants.App_Secondary_Color;
            viewBG8.BackgroundColor = Constants.App_Primary_Color;
            viewBG9.BackgroundColor = Constants.App_Secondary_Color;

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