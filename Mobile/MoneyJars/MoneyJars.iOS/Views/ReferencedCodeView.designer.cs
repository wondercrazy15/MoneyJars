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
    [Register ("ReferencedCodeView")]
    partial class ReferencedCodeView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnBack { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSubmit { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblEnterCodeTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblReferenceCodeMessage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblReferenceCodeTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtReferenceCode { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewExtraSpace { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewMainBG { get; set; }

        [Action ("btnBackClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnBackClicked (UIKit.UIButton sender);

        [Action ("btnSubmitClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSubmitClicked (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnBack != null) {
                btnBack.Dispose ();
                btnBack = null;
            }

            if (btnSubmit != null) {
                btnSubmit.Dispose ();
                btnSubmit = null;
            }

            if (lblEnterCodeTitle != null) {
                lblEnterCodeTitle.Dispose ();
                lblEnterCodeTitle = null;
            }

            if (lblReferenceCodeMessage != null) {
                lblReferenceCodeMessage.Dispose ();
                lblReferenceCodeMessage = null;
            }

            if (lblReferenceCodeTitle != null) {
                lblReferenceCodeTitle.Dispose ();
                lblReferenceCodeTitle = null;
            }

            if (txtReferenceCode != null) {
                txtReferenceCode.Dispose ();
                txtReferenceCode = null;
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