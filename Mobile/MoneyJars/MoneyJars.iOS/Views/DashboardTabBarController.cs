using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.iOS.Helper;
using System;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class DashboardTabBarController : UITabBarController
    {
        public DashboardTabBarController (IntPtr handle) : base (handle)
        {
            this.TabBar.SelectedImageTintColor = Constants.App_Buttons_Color;


            //HomeView home = Storyboard.InstantiateViewController("HomeView") as HomeView;
            //HistoryView history = Storyboard.InstantiateViewController("HistoryView") as HistoryView;
            //AddTransactionView addTransaction = Storyboard.InstantiateViewController("AddTransactionView") as AddTransactionView;
            //ReportsView reports = Storyboard.InstantiateViewController("ReportsView") as ReportsView;
            //SettingView setting = Storyboard.InstantiateViewController("SettingView") as SettingView;

            //var tabs = new UIViewController[] {
            //    home, history, addTransaction, reports, setting
            //};

            //ViewControllers = tabs;

        }


        public override UIStatusBarStyle PreferredStatusBarStyle()
        {
            return UIStatusBarStyle.LightContent;
        }

    }
}