using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace MoneyJars.iOS
{
    internal class HistoryListTableSource : UITableViewSource
    {
        private List<string> historyList;
        private HistoryView historyView;

        public HistoryListTableSource(List<string> historyList, HistoryView historyView)
        {
            this.historyList = historyList;
            this.historyView = historyView;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            HistoryCell cell = tableView.DequeueReusableCell("HistoryCell", indexPath) as HistoryCell;

            //string data = historyList[indexPath.Row];
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