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
    [Register ("HistoryView")]
    partial class HistoryView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSelectAJarTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSelectedJar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView tblHistory { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewBG1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewBG2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewExtraSpace { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblSelectAJarTitle != null) {
                lblSelectAJarTitle.Dispose ();
                lblSelectAJarTitle = null;
            }

            if (lblSelectedJar != null) {
                lblSelectedJar.Dispose ();
                lblSelectedJar = null;
            }

            if (tblHistory != null) {
                tblHistory.Dispose ();
                tblHistory = null;
            }

            if (viewBG1 != null) {
                viewBG1.Dispose ();
                viewBG1 = null;
            }

            if (viewBG2 != null) {
                viewBG2.Dispose ();
                viewBG2 = null;
            }

            if (viewExtraSpace != null) {
                viewExtraSpace.Dispose ();
                viewExtraSpace = null;
            }
        }
    }
}