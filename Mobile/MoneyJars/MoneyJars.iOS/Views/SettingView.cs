using Foundation;
using MessageUI;
using MoneyJars.Core.Helper;
using MoneyJars.iOS.Helper;
using System;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class SettingView : UIViewController, IMFMailComposeViewControllerDelegate
    {

        MFMailComposeViewController mailVC;

        public SettingView (IntPtr handle) : base (handle)
        {
        }

        public SettingView()
        {
        }

        public override void ViewDidLoad()
        {
            SetColors();
        }

        public override UIStatusBarStyle PreferredStatusBarStyle()
        {
            return UIStatusBarStyle.LightContent;
        }

        private void SetColors()
        {
            viewExtraSpace.BackgroundColor = Constants.App_Extra_Space_Color;

            viewMain.BackgroundColor = Constants.App_Primary_Color;

            viewBG1.BackgroundColor = Constants.App_Primary_Color;
            viewBG2.BackgroundColor = Constants.App_Secondary_Color;
            viewBG3.BackgroundColor = Constants.App_Secondary_Color;
            viewBG4.BackgroundColor = Constants.App_Secondary_Color;
            viewBG5.BackgroundColor = Constants.App_Secondary_Color;
            viewBG6.BackgroundColor = Constants.App_Secondary_Color;

            imgUserProfile.BackgroundColor = Constants.App_Buttons_Color;
            lblUserName.TextColor = Constants.App_Text_Color;
            lblAccountType.TextColor = Constants.App_Text_Color;

            lblTotalScoreTitle.TextColor = Constants.App_Text_Color;
            lblTotalScoreValue.TextColor = Constants.App_Text_Color;
            lblDailyRewardTitle.TextColor = Constants.App_Text_Color;
            progressDailyReward.ProgressTintColor = Constants.App_Buttons_Color;

            lblSeparator1.BackgroundColor = Constants.App_Text_Color;

            imgReferenceCode.TintColor = Constants.App_Text_Color;
            lblReferenceCodeTitle.TextColor = Constants.App_Text_Color;
            lblReferenceCodeValue.TextColor = Constants.App_Text_Color;
            btnReferenceCode.TintColor = Constants.App_Text_Color;
            imgArrow2.TintColor = Constants.App_Text_Color;
            lblSeparator2.BackgroundColor = Constants.App_Text_Color;

            imgEnterCode.TintColor = Constants.App_Text_Color;
            lblEnterCodeTitle.TextColor = Constants.App_Text_Color;
            imgArrow3.TintColor = Constants.App_Text_Color;

            imgGeneralSetting.TintColor = Constants.App_Text_Color;
            lblGeneralSettingTitle.TextColor = Constants.App_Text_Color;
            imgArrow4.TintColor = Constants.App_Text_Color;
            lblSeparator4.BackgroundColor = Constants.App_Text_Color;

            imgJarSetting.TintColor = Constants.App_Text_Color;
            lblJarSettingTitle.TextColor = Constants.App_Text_Color;
            imgArrow5.TintColor = Constants.App_Text_Color;
            lblSeparator5.BackgroundColor = Constants.App_Text_Color;

            imgRecurringTransactions.TintColor = Constants.App_Text_Color;
            lblRecurringTransactionTitle.TextColor = Constants.App_Text_Color;
            lblSeparator6.BackgroundColor = Constants.App_Text_Color;
            imgArrow6.TintColor = Constants.App_Text_Color;

            imgGuide.TintColor = Constants.App_Text_Color;
            lblGuideTitle.TextColor = Constants.App_Text_Color;
            imgArrow7.TintColor = Constants.App_Text_Color;
            lblSeparator7.BackgroundColor = Constants.App_Text_Color;

            imgFAQ.TintColor = Constants.App_Text_Color;
            lblFAQTitle.TextColor = Constants.App_Text_Color;
            imgArrow8.TintColor = Constants.App_Text_Color;

            imgFacebookFan.TintColor = Constants.App_Text_Color;
            lblFacebookFanTitle.TextColor = Constants.App_Text_Color;
            imgArrow9.TintColor = Constants.App_Text_Color;
            lblSeparator9.BackgroundColor = Constants.App_Text_Color;

            imgRating.TintColor = Constants.App_Text_Color;
            lblRatingTitle.TextColor = Constants.App_Text_Color;
            imgArrow10.TintColor = Constants.App_Text_Color;
            lblSeparator10.BackgroundColor = Constants.App_Text_Color;

            lblFeedbackTitle.TextColor = Constants.App_Text_Color;
            imgFeedback.TintColor = Constants.App_Text_Color;
            imgArrow11.TintColor = Constants.App_Text_Color;
            lblSeparator11.BackgroundColor = Constants.App_Text_Color;

            lblTermTitle.TextColor = Constants.App_Text_Color;
            imgTerm.TintColor = Constants.App_Text_Color;
            imgArrow12.TintColor = Constants.App_Text_Color;
            lblSeparator12.BackgroundColor = Constants.App_Text_Color;

            imgInformation.TintColor = Constants.App_Text_Color;
            lblInformationTitle.TextColor = Constants.App_Text_Color;
            imgArrow13.TintColor = Constants.App_Text_Color;
        }

        partial void btnMyProfileClicked(UIButton sender)
        {
            ProfileView vc = Storyboard.InstantiateViewController("ProfileView") as ProfileView;
            NavigationController.PushViewController(vc, true);
        }

        partial void MyReferenceCodeClicked(UIButton sender)
        {
            MyReferenceCodeView vc = Storyboard.InstantiateViewController("MyReferenceCodeView") as MyReferenceCodeView;
            NavigationController.PushViewController(vc, true);
        }

        partial void btnReferencedCodeClicked(UIButton sender)
        {
            ReferencedCodeView vc = Storyboard.InstantiateViewController("ReferencedCodeView") as ReferencedCodeView;
            NavigationController.PushViewController(vc, true);
        }

        partial void btnGeneralSettingClicked(UIButton sender)
        {
            GeneralSettingView vc = Storyboard.InstantiateViewController("GeneralSettingView") as GeneralSettingView;
            NavigationController.PushViewController(vc, true);
        }

        partial void btnJarSettingClicked(UIButton sender)
        {
            JarSettingView vc = Storyboard.InstantiateViewController("JarSettingView") as JarSettingView;
            NavigationController.PushViewController(vc, true);
        }

        partial void btnRecurringTransactionClicked(UIButton sender)
        {
            RecurringTransactionView vc = Storyboard.InstantiateViewController("RecurringTransactionView") as RecurringTransactionView;
            NavigationController.PushViewController(vc, true);
        }

        partial void btnGuideClicked(UIButton sender)
        {
            GuideView vc = Storyboard.InstantiateViewController("GuideView") as GuideView;
            NavigationController.PushViewController(vc, true);
        }

        partial void btnFAQClicked(UIButton sender)
        {
            FAQsView vc = Storyboard.InstantiateViewController("FAQsView") as FAQsView;
            NavigationController.PushViewController(vc, true);
        }

        partial void btnFacebookFanpageClicked(UIButton sender)
        {
            UIApplication.SharedApplication.OpenUrl(new NSUrl(GlobalConst.FacebookUrl));
        }

        partial void btnRateAppClicked(UIButton sender)
        {
            UIApplication.SharedApplication.OpenUrl(new NSUrl(GlobalConst.iTunesUrl));
        }

        partial void btnFeedbackClicked(UIButton sender)
        {
            if(MFMailComposeViewController.CanSendMail)
            {
                mailVC = new MFMailComposeViewController();
                mailVC.MailComposeDelegate = this;
                mailVC.SetSubject("Feedback for iOS App");
                mailVC.SetMessageBody("Enter your feedback", false);
                mailVC.SetToRecipients(new string[1] { "support@moneyoi.io" });
                PresentViewController(mailVC, true, () =>
                {

                });
            }
            
        }

        partial void btnTermClicked(UIButton sender)
        {
            TermsView vc = Storyboard.InstantiateViewController("TermsView") as TermsView;
            NavigationController.PushViewController(vc, true);
        }

        partial void btnAppInformationClicked(UIButton sender)
        {
            InformationView vc = Storyboard.InstantiateViewController("InformationView") as InformationView;
            NavigationController.PushViewController(vc, true);
        }
    }
}