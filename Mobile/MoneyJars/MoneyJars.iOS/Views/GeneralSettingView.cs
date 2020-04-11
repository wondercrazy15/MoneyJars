using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.Core.ViewModels;
using MoneyJars.iOS.Views;
using System;
using UIKit;
using LocalAuthentication;
using MoneyJars.iOS.Helper;

namespace MoneyJars.iOS
{
    public partial class GeneralSettingView : BaseView<GeneralSettingViewModel>
    {
        bool isOnPasscode = false;
        bool isOnTouchId = false;
        bool isOnEnableNotification = false;

        string BiometryType = "";


        public GeneralSettingView (IntPtr handle) : base (handle)
        {
        }

        public GeneralSettingView()
        {
        }

        public override void ViewDidLoad()
        {
            SetColors();
            SetSwitch();
        }

        private void SetSwitch()
        {
            if (isOnPasscode)
            {
                imgPasscodeSwitch.Image = UIImage.FromBundle("toggle-on");
            }
            else
            {
                imgPasscodeSwitch.Image = UIImage.FromBundle("toggle-off");
            }

            if (isOnTouchId)
            {
                imgTouchIdSwitch.Image = UIImage.FromBundle("toggle-on");
            }
            else
            {
                imgTouchIdSwitch.Image = UIImage.FromBundle("toggle-off");
            }

            if (isOnEnableNotification)
            {
                imgNotificationSwitch.Image = UIImage.FromBundle("toggle-on");
            }
            else
            {
                imgNotificationSwitch.Image = UIImage.FromBundle("toggle-off");
            }

        }

        public override UIStatusBarStyle PreferredStatusBarStyle()
        {
            return UIStatusBarStyle.LightContent;
        }

        private void SetColors()
        {
            viewExtraSpace.BackgroundColor = Constants.App_Extra_Space_Color;
            viewMain.BackgroundColor = Constants.App_Primary_Color;

            btnBack.SetTitleColor(Constants.App_Text_Color, UIControlState.Normal);
            lblGeneralSettingTitle.TextColor = Constants.App_Text_Color;

            viewBG1.BackgroundColor = Constants.App_Secondary_Color;
            viewBG2.BackgroundColor = Constants.App_Secondary_Color;
            viewBG3.BackgroundColor = Constants.App_Secondary_Color;
            viewBG4.BackgroundColor = Constants.App_Secondary_Color;

            imgPasscode.TintColor = Constants.App_Text_Color;
            lblPasscodeTitle.TextColor = Constants.App_Text_Color;
            lblSeparator1.BackgroundColor = Constants.App_Text_Color;

            imgTouchId.TintColor = Constants.App_Text_Color;
            lblTouchIdTitle.TextColor = Constants.App_Text_Color;

            lblLanguageTitle.TextColor = Constants.App_Text_Color;
            imgLanguage.TintColor = Constants.App_Text_Color;
            lblSeparator2.BackgroundColor = Constants.App_Text_Color;

            lblCurrencyTitle.TextColor = Constants.App_Text_Color;
            imgCurrency.TintColor = Constants.App_Text_Color;

            imgNotification.TintColor = Constants.App_Text_Color;
            lblNotificationTitle.TextColor = Constants.App_Text_Color;
            lblSeparator3.BackgroundColor = Constants.App_Text_Color;

            imgNotificationTime.TintColor = Constants.App_Text_Color;
            lblNotificationTimeTitle.TextColor = Constants.App_Text_Color;

            lblFactoryResetTitle.TextColor = Constants.App_Text_Color;
            imgFactoryReset.TintColor = Constants.App_Text_Color;
            lblSeparator4.BackgroundColor = Constants.App_Text_Color;

            lblVersionTitle.TextColor = Constants.App_Text_Color;


        }

        partial void btnBackClicked(UIButton sender)
        {
            NavigationController.PopViewController(true);
        }

        partial void btnPasscodeSwitchClicked(UIButton sender)
        {
            if (isOnPasscode)
            {
                imgPasscodeSwitch.Image = UIImage.FromBundle("toggle-off");
                isOnPasscode = false;
            }
            else
            {
                _ = GlobalMethod.DelayedMethod(500, () =>
                {
                    PasscodeView vc = Storyboard.InstantiateViewController("PasscodeView") as PasscodeView;
                    PresentViewController(vc, true, null);
                });
                
                imgPasscodeSwitch.Image = UIImage.FromBundle("toggle-on");
                isOnPasscode = true;
            }
        }

        partial void btnTouchIdSwitchClicked(UIButton sender)
        {
            if (isOnTouchId)
            {
                imgTouchIdSwitch.Image = UIImage.FromBundle("toggle-off");
                isOnTouchId = false;
            }
            else
            {
                _ = GlobalMethod.DelayedMethod(500, () =>
                {
                    LoadTouchId();
                });
                imgTouchIdSwitch.Image = UIImage.FromBundle("toggle-on");
                isOnTouchId = true;
            }
        }

        private void LoadTouchId()
        {
            StartLoadingTouchId();
        }

        private void StartLoadingTouchId()
        {
            
        }

        partial void btnEnableNotificationSwitchClicked(UIButton sender)
        {
            if (isOnEnableNotification)
            {
                imgNotificationSwitch.Image = UIImage.FromBundle("toggle-off");
                isOnEnableNotification = false;
            }
            else
            {
                imgNotificationSwitch.Image = UIImage.FromBundle("toggle-on");
                isOnEnableNotification = true;
            }
        }
    }
}