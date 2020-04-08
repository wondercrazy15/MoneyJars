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
    [Register ("HistoryCell")]
    partial class HistoryCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton imgHistory { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton imgJar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblHistoryAmount { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblHistoryDate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblHistoryMessage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblHistoryTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSeparator { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imgHistory != null) {
                imgHistory.Dispose ();
                imgHistory = null;
            }

            if (imgJar != null) {
                imgJar.Dispose ();
                imgJar = null;
            }

            if (lblHistoryAmount != null) {
                lblHistoryAmount.Dispose ();
                lblHistoryAmount = null;
            }

            if (lblHistoryDate != null) {
                lblHistoryDate.Dispose ();
                lblHistoryDate = null;
            }

            if (lblHistoryMessage != null) {
                lblHistoryMessage.Dispose ();
                lblHistoryMessage = null;
            }

            if (lblHistoryTitle != null) {
                lblHistoryTitle.Dispose ();
                lblHistoryTitle = null;
            }

            if (lblSeparator != null) {
                lblSeparator.Dispose ();
                lblSeparator = null;
            }
        }
    }
}