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
    [Register ("ReportsView")]
    partial class ReportsView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnLifeTime { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnMonth { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnMoreReports { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgArrowDown { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgSelectDateArrow { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNoData { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblReportsTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSelectedDate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSelectedJar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSelectJarTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewBG1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewBG2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewBG3 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewBG4 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewExtraSpace { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewSwapButton { get; set; }

        [Action ("btnLifeTimeClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnLifeTimeClicked (UIKit.UIButton sender);

        [Action ("btnMonthClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnMonthClicked (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnLifeTime != null) {
                btnLifeTime.Dispose ();
                btnLifeTime = null;
            }

            if (btnMonth != null) {
                btnMonth.Dispose ();
                btnMonth = null;
            }

            if (btnMoreReports != null) {
                btnMoreReports.Dispose ();
                btnMoreReports = null;
            }

            if (imgArrowDown != null) {
                imgArrowDown.Dispose ();
                imgArrowDown = null;
            }

            if (imgSelectDateArrow != null) {
                imgSelectDateArrow.Dispose ();
                imgSelectDateArrow = null;
            }

            if (lblNoData != null) {
                lblNoData.Dispose ();
                lblNoData = null;
            }

            if (lblReportsTitle != null) {
                lblReportsTitle.Dispose ();
                lblReportsTitle = null;
            }

            if (lblSelectedDate != null) {
                lblSelectedDate.Dispose ();
                lblSelectedDate = null;
            }

            if (lblSelectedJar != null) {
                lblSelectedJar.Dispose ();
                lblSelectedJar = null;
            }

            if (lblSelectJarTitle != null) {
                lblSelectJarTitle.Dispose ();
                lblSelectJarTitle = null;
            }

            if (viewBG1 != null) {
                viewBG1.Dispose ();
                viewBG1 = null;
            }

            if (viewBG2 != null) {
                viewBG2.Dispose ();
                viewBG2 = null;
            }

            if (viewBG3 != null) {
                viewBG3.Dispose ();
                viewBG3 = null;
            }

            if (viewBG4 != null) {
                viewBG4.Dispose ();
                viewBG4 = null;
            }

            if (viewExtraSpace != null) {
                viewExtraSpace.Dispose ();
                viewExtraSpace = null;
            }

            if (viewSwapButton != null) {
                viewSwapButton.Dispose ();
                viewSwapButton = null;
            }
        }
    }
}