// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MoneyJars.iOS
{
    [Register ("SelectCurrencyView")]
    partial class SelectCurrencyView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView tblCurrencyList { get; set; }

        [Action ("btnBackClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnBackClicked (UIKit.UIButton sender);

        [Action ("DidUpdateSearchCurrency:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DidUpdateSearchCurrency (UIKit.UITextField sender);

        void ReleaseDesignerOutlets ()
        {
            if (tblCurrencyList != null) {
                tblCurrencyList.Dispose ();
                tblCurrencyList = null;
            }
        }
    }
}