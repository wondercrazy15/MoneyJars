using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace MoneyJars.iOS
{
    internal class JarsListTableSource : UITableViewSource
    {
        private List<string> jarsList;
        private HomeView homeView;

        public JarsListTableSource(List<string> jarsList, HomeView homeView)
        {
            this.jarsList = jarsList;
            this.homeView = homeView;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            JarListCell cell = tableView.DequeueReusableCell("JarListCell", indexPath) as JarListCell;

            //string data = historyList[indexPath.Row];
            //cell.UpdateCell(data);
            cell.SelectionStyle = UITableViewCellSelectionStyle.None;
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            homeView.UpdateJarListTableHeight(6);
            return 6;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {

        }
    }
}