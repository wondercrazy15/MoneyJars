using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.Core.ViewModels;
using MoneyJars.iOS.Views;
using System;
using System.Collections.Generic;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class SelectCurrencyView : BaseView<SelectCurrencyViewModel>
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

            SetColors();

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
            currencyList.Add(first);
            currencyList.Add(second);
            currencyList.Add(third);
            currencyList.Add(first);
            currencyList.Add(second);
            currencyList.Add(third);

            //tblCurrencyList.Delegate = this;
            tblCurrencyList.Source = new SelectCurrencyTableSource(currencyList, this);
            



        }

        private void SetColors()
        {
            View.BackgroundColor = GlobalConst.App_Extra_Space_Color;
            btnBack.TintColor = GlobalConst.App_Text_Color;
            lblTitle.TextColor = GlobalConst.App_Text_Color;
            viewTopBar.BackgroundColor = GlobalConst.App_Primary_Color;
            txtSearchCurrency.TextColor = GlobalConst.App_Primary_Color;
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

        }

        public override UIStatusBarStyle PreferredStatusBarStyle()
        {
            return UIStatusBarStyle.LightContent;
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