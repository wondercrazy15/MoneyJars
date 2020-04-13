using Foundation;
using MoneyJars.Core.ViewModels;
using MoneyJars.iOS.Helper;
using MoneyJars.iOS.Views;
using System;
using System.Collections.Generic;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class HistoryDetailView : BaseView<HistoryDetailViewModel>
    {
        public HistoryDetailView (IntPtr handle) : base (handle)
        {
        }

        public HistoryDetailView()
        {
        }

        public override void ViewDidLoad()
        {
            SetColors();


            List<string> historyList = new List<string>();
            tblHistory.Source = new HistoryDetailTableSource(historyList, this);
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

            viewBG1.BackgroundColor = Constants.App_Primary_Color;
            viewBG2.BackgroundColor = Constants.App_Secondary_Color;

            tblHistory.BackgroundColor = Constants.App_Primary_Color;

            lblSelectAJarTitle.TextColor = Constants.App_Text_Color;
            lblSelectedJar.TextColor = Constants.App_Text_Color;

            imgDownArrowSelectedJar.TintColor = Constants.App_Text_Color;

        }

        partial void btnBackClicked(UIButton sender)
        {
            NavigationController.PopViewController(true);
        }
    }
}