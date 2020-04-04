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
        UIKit.UIButton btnBack { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView tblCurrencyList { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtSearchCurrency { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewTopBar { get; set; }

        [Action ("btnBackClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnBackClicked (UIKit.UIButton sender);

        [Action ("DidUpdateSearchCurrency:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DidUpdateSearchCurrency (UIKit.UITextField sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnBack != null) {
                btnBack.Dispose ();
                btnBack = null;
            }

            if (lblTitle != null) {
                lblTitle.Dispose ();
                lblTitle = null;
            }

            if (tblCurrencyList != null) {
                tblCurrencyList.Dispose ();
                tblCurrencyList = null;
            }

            if (txtSearchCurrency != null) {
                txtSearchCurrency.Dispose ();
                txtSearchCurrency = null;
            }

            if (viewTopBar != null) {
                viewTopBar.Dispose ();
                viewTopBar = null;
            }
        }
    }
}