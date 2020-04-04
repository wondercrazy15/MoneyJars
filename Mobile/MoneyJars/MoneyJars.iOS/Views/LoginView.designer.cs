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
    [Register ("LoginView")]
    partial class LoginView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgAppLogo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblAppName { get; set; }

        [Action ("btnLoginWithFacebookClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnLoginWithFacebookClicked (UIKit.UIButton sender);

        [Action ("btnLoginWithGoggleClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnLoginWithGoggleClicked (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (imgAppLogo != null) {
                imgAppLogo.Dispose ();
                imgAppLogo = null;
            }

            if (lblAppName != null) {
                lblAppName.Dispose ();
                lblAppName = null;
            }
        }
    }
}