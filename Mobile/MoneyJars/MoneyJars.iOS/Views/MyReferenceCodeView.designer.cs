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
    [Register ("MyReferenceCodeView")]
    partial class MyReferenceCodeView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnBack { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnRetry { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnShare { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNoData { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblReferenceCodeTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblReferenceCodeValue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblThanksForReferMessage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView tblReferedFriends { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewBG1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewExtraSpace { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewMainBG { get; set; }

        [Action ("btnBackClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnBackClicked (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnBack != null) {
                btnBack.Dispose ();
                btnBack = null;
            }

            if (btnRetry != null) {
                btnRetry.Dispose ();
                btnRetry = null;
            }

            if (btnShare != null) {
                btnShare.Dispose ();
                btnShare = null;
            }

            if (lblNoData != null) {
                lblNoData.Dispose ();
                lblNoData = null;
            }

            if (lblReferenceCodeTitle != null) {
                lblReferenceCodeTitle.Dispose ();
                lblReferenceCodeTitle = null;
            }

            if (lblReferenceCodeValue != null) {
                lblReferenceCodeValue.Dispose ();
                lblReferenceCodeValue = null;
            }

            if (lblThanksForReferMessage != null) {
                lblThanksForReferMessage.Dispose ();
                lblThanksForReferMessage = null;
            }

            if (tblReferedFriends != null) {
                tblReferedFriends.Dispose ();
                tblReferedFriends = null;
            }

            if (viewBG1 != null) {
                viewBG1.Dispose ();
                viewBG1 = null;
            }

            if (viewExtraSpace != null) {
                viewExtraSpace.Dispose ();
                viewExtraSpace = null;
            }

            if (viewMainBG != null) {
                viewMainBG.Dispose ();
                viewMainBG = null;
            }
        }
    }
}