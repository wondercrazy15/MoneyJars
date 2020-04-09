using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace MoneyJars.iOS
{
    internal class RecurringTransactionListTableSource : UITableViewSource
    {
        private List<string> transactionList;
        private RecurringTransactionView recurringTransactionView;

        public RecurringTransactionListTableSource(List<string> transactionList, RecurringTransactionView recurringTransactionView)
        {
            this.transactionList = transactionList;
            this.recurringTransactionView = recurringTransactionView;
        }


        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            HistoryCell cell = tableView.DequeueReusableCell("HistoryCell", indexPath) as HistoryCell;

            //string data = jarList[indexPath.Row];
            //cell.UpdateCell(data);
            cell.SelectionStyle = UITableViewCellSelectionStyle.None;
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return 10;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {

        }
    }
}