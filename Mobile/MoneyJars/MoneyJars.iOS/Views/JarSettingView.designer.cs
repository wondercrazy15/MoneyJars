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
    [Register ("JarSettingView")]
    partial class JarSettingView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnBack { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSave { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblJarSettingTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblPieChartHere { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView tblJarSettings { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewExtraSpace { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewMain { get; set; }

        [Action ("btnBackClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnBackClicked (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnBack != null) {
                btnBack.Dispose ();
                btnBack = null;
            }

            if (btnSave != null) {
                btnSave.Dispose ();
                btnSave = null;
            }

            if (lblJarSettingTitle != null) {
                lblJarSettingTitle.Dispose ();
                lblJarSettingTitle = null;
            }

            if (lblPieChartHere != null) {
                lblPieChartHere.Dispose ();
                lblPieChartHere = null;
            }

            if (tblJarSettings != null) {
                tblJarSettings.Dispose ();
                tblJarSettings = null;
            }

            if (viewExtraSpace != null) {
                viewExtraSpace.Dispose ();
                viewExtraSpace = null;
            }

            if (viewMain != null) {
                viewMain.Dispose ();
                viewMain = null;
            }
        }
    }
}