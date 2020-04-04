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
    [Register ("JarListCell")]
    partial class JarListCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnJarImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblJarAmount { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblJarTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIProgressView progressJarAmount { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnJarImage != null) {
                btnJarImage.Dispose ();
                btnJarImage = null;
            }

            if (lblJarAmount != null) {
                lblJarAmount.Dispose ();
                lblJarAmount = null;
            }

            if (lblJarTitle != null) {
                lblJarTitle.Dispose ();
                lblJarTitle = null;
            }

            if (progressJarAmount != null) {
                progressJarAmount.Dispose ();
                progressJarAmount = null;
            }
        }
    }
}