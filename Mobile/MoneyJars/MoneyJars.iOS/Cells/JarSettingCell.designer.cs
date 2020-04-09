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
    [Register ("JarSettingCell")]
    partial class JarSettingCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnDecrease { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnIncrease { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton imgBtnJarSetting { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblJarPercentage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblJarTitle { get; set; }

        [Action ("btnDecreaseClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnDecreaseClicked (UIKit.UIButton sender);

        [Action ("btnIncreaseClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnIncreaseClicked (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnDecrease != null) {
                btnDecrease.Dispose ();
                btnDecrease = null;
            }

            if (btnIncrease != null) {
                btnIncrease.Dispose ();
                btnIncrease = null;
            }

            if (imgBtnJarSetting != null) {
                imgBtnJarSetting.Dispose ();
                imgBtnJarSetting = null;
            }

            if (lblJarPercentage != null) {
                lblJarPercentage.Dispose ();
                lblJarPercentage = null;
            }

            if (lblJarTitle != null) {
                lblJarTitle.Dispose ();
                lblJarTitle = null;
            }
        }
    }
}