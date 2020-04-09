using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.Core.ViewModels;
using MoneyJars.iOS.Views;
using System;
using System.Collections.Generic;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class RecurringTransactionView : BaseView<RecurringTransactionViewModel>
    {
        public RecurringTransactionView (IntPtr handle) : base (handle)
        {
        }

        public RecurringTransactionView()
        {
        }

        public override void ViewDidLoad()
        {
            SetColors();

            List<string> transactionList = new List<string>();
            tblRecurringTransaction.Source = new RecurringTransactionListTableSource(transactionList, this);

        }

        public override UIStatusBarStyle PreferredStatusBarStyle()
        {
            return UIStatusBarStyle.LightContent;
        }

        private void SetColors()
        {
            viewExtraSpace.BackgroundColor = GlobalConst.App_Extra_Space_Color;
            viewMain.BackgroundColor = GlobalConst.App_Primary_Color;

            tblRecurringTransaction.BackgroundColor = GlobalConst.App_Primary_Color;

            btnBack.TintColor = GlobalConst.App_Text_Color;
            lblRecurringTransactionTitle.TextColor = GlobalConst.App_Text_Color;


        }

        partial void btnBackClicked(UIButton sender)
        {
            NavigationController.PopViewController(true);
        }
    }
}