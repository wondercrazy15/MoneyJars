using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace MoneyJars.iOS
{
    internal class JarSettingListTableSource : UITableViewSource
    {
        private List<string> jarList;
        private JarSettingView jarSettingView;

        public JarSettingListTableSource(List<string> jarList, JarSettingView jarSettingView)
        {
            this.jarList = jarList;
            this.jarSettingView = jarSettingView;
        }


        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            JarSettingCell cell = tableView.DequeueReusableCell("JarSettingCell", indexPath) as JarSettingCell;

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