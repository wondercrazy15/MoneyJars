using Foundation;
using MoneyJars.Core.ViewModels;
using MoneyJars.iOS.Views;
using System;
using System.Collections.Generic;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class SelectCurrencyView : BaseView<SelectCurrencyViewModel>, IUITableViewDelegate, IUITableViewDataSource
    {
        
        List<Dictionary<string, string>> currencyList = new List<Dictionary<string, string>>();

        public SelectCurrencyView (IntPtr handle) : base (handle)
        {
        }

        public SelectCurrencyView()
        {
        }

        public override void ViewDidLoad()
        {
            //base.ViewDidLoad();

            Dictionary<string, string> first = new Dictionary<string, string>();
            first.Add("Title", "US dollars");
            first.Add("Name", "USD");

            Dictionary<string, string> second = new Dictionary<string, string>();
            second.Add("Title", "Indian rupees");
            second.Add("Name", "INR");

            Dictionary<string, string> third = new Dictionary<string, string>();
            third.Add("Title", "Euros");
            third.Add("Name", "EUR");

            currencyList.Add(first);
            currencyList.Add(second);
            currencyList.Add(third);

            tblCurrencyList.Delegate = this;
            tblCurrencyList.DataSource = this;


        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

        }


    }

        public nint RowsInSection(UITableView tableView, nint section)
        {
            return currencyList.Count;
        }

        public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            CurrencyListCell cell = tblCurrencyList.DequeueReusableCell("CurrencyListCell", indexPath) as CurrencyListCell;

            Dictionary<string, string> data = currencyList[indexPath.Row];
            

            return cell;
        }

        partial void btnBackClicked(UIButton sender)
        {
            NavigationController.PopViewController(true);
        }

        partial void DidUpdateSearchCurrency(UITextField sender)
        {
            
        }
    }
}