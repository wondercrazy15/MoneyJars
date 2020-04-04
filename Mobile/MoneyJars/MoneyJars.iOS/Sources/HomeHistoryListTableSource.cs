using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace MoneyJars.iOS
{
    internal class HomeHistoryListTableSource : UITableViewSource
    {
        private List<string> historyList;
        private HomeView homeView;

        public HomeHistoryListTableSource(List<string> historyList, HomeView homeView)
        {
            this.historyList = historyList;
            this.homeView = homeView;
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
            homeView.UpdateHistoryTableHeight(3);
            return 3;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            
        }

    }
}