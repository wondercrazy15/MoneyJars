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
    [Register ("CurrencyListCell")]
    partial class CurrencyListCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCurrencyName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCurrencyTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewBackGround { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblCurrencyName != null) {
                lblCurrencyName.Dispose ();
                lblCurrencyName = null;
            }

            if (lblCurrencyTitle != null) {
                lblCurrencyTitle.Dispose ();
                lblCurrencyTitle = null;
            }

            if (viewBackGround != null) {
                viewBackGround.Dispose ();
                viewBackGround = null;
            }
        }
    }
}