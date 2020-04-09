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
    [Register ("GeneralSettingView")]
    partial class GeneralSettingView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnBack { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgCurrency { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgFactoryReset { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgLanguage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgNotification { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgNotificationSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgNotificationTime { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgPasscode { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgPasscodeSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgTouchId { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgTouchIdSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCurrencyTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblFactoryResetTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblGeneralSettingTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblLanguageTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNotificationTimeTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblNotificationTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblPasscodeTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSeparator1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSeparator2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSeparator3 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSeparator4 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTouchIdTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblVersionTitle { get; set; }

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
        UIKit.UIView viewMain { get; set; }

        [Action ("btnBackClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnBackClicked (UIKit.UIButton sender);

        [Action ("btnEnableNotificationSwitchClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnEnableNotificationSwitchClicked (UIKit.UIButton sender);

        [Action ("btnPasscodeSwitchClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnPasscodeSwitchClicked (UIKit.UIButton sender);

        [Action ("btnTouchIdSwitchClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnTouchIdSwitchClicked (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnBack != null) {
                btnBack.Dispose ();
                btnBack = null;
            }

            if (imgCurrency != null) {
                imgCurrency.Dispose ();
                imgCurrency = null;
            }

            if (imgFactoryReset != null) {
                imgFactoryReset.Dispose ();
                imgFactoryReset = null;
            }

            if (imgLanguage != null) {
                imgLanguage.Dispose ();
                imgLanguage = null;
            }

            if (imgNotification != null) {
                imgNotification.Dispose ();
                imgNotification = null;
            }

            if (imgNotificationSwitch != null) {
                imgNotificationSwitch.Dispose ();
                imgNotificationSwitch = null;
            }

            if (imgNotificationTime != null) {
                imgNotificationTime.Dispose ();
                imgNotificationTime = null;
            }

            if (imgPasscode != null) {
                imgPasscode.Dispose ();
                imgPasscode = null;
            }

            if (imgPasscodeSwitch != null) {
                imgPasscodeSwitch.Dispose ();
                imgPasscodeSwitch = null;
            }

            if (imgTouchId != null) {
                imgTouchId.Dispose ();
                imgTouchId = null;
            }

            if (imgTouchIdSwitch != null) {
                imgTouchIdSwitch.Dispose ();
                imgTouchIdSwitch = null;
            }

            if (lblCurrencyTitle != null) {
                lblCurrencyTitle.Dispose ();
                lblCurrencyTitle = null;
            }

            if (lblFactoryResetTitle != null) {
                lblFactoryResetTitle.Dispose ();
                lblFactoryResetTitle = null;
            }

            if (lblGeneralSettingTitle != null) {
                lblGeneralSettingTitle.Dispose ();
                lblGeneralSettingTitle = null;
            }

            if (lblLanguageTitle != null) {
                lblLanguageTitle.Dispose ();
                lblLanguageTitle = null;
            }

            if (lblNotificationTimeTitle != null) {
                lblNotificationTimeTitle.Dispose ();
                lblNotificationTimeTitle = null;
            }

            if (lblNotificationTitle != null) {
                lblNotificationTitle.Dispose ();
                lblNotificationTitle = null;
            }

            if (lblPasscodeTitle != null) {
                lblPasscodeTitle.Dispose ();
                lblPasscodeTitle = null;
            }

            if (lblSeparator1 != null) {
                lblSeparator1.Dispose ();
                lblSeparator1 = null;
            }

            if (lblSeparator2 != null) {
                lblSeparator2.Dispose ();
                lblSeparator2 = null;
            }

            if (lblSeparator3 != null) {
                lblSeparator3.Dispose ();
                lblSeparator3 = null;
            }

            if (lblSeparator4 != null) {
                lblSeparator4.Dispose ();
                lblSeparator4 = null;
            }

            if (lblTouchIdTitle != null) {
                lblTouchIdTitle.Dispose ();
                lblTouchIdTitle = null;
            }

            if (lblVersionTitle != null) {
                lblVersionTitle.Dispose ();
                lblVersionTitle = null;
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

            if (viewMain != null) {
                viewMain.Dispose ();
                viewMain = null;
            }
        }
    }
}