using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace MoneyJars.iOS
{
    internal class SelectCurrencyTableSource : UITableViewSource
    {
        private List<Dictionary<string, string>> currencyList;
        private SelectCurrencyView selectCurrencyView;

        public SelectCurrencyTableSource(List<Dictionary<string, string>> currencyList, SelectCurrencyView selectCurrencyView)
        {
            this.currencyList = currencyList;
            this.selectCurrencyView = selectCurrencyView;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            CurrencyListCell cell = tableView.DequeueReusableCell("CurrencyListCell", indexPath) as CurrencyListCell;

            Dictionary<string, string> data = currencyList[indexPath.Row];
            cell.UpdateCell(data);
            cell.SelectionStyle = UITableViewCellSelectionStyle.None;
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return currencyList.Count;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            DashboardTabBarController vc = selectCurrencyView.Storyboard.InstantiateViewController("DashboardTabBarController") as DashboardTabBarController;
            selectCurrencyView.NavigationController.PushViewController(vc, true);
        }
    }
}