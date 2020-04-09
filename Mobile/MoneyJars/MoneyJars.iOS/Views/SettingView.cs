using Foundation;
using MoneyJars.Core.Helper;
using System;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class SettingView : UIViewController
    {
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
            viewExtraSpace.BackgroundColor = GlobalConst.App_Extra_Space_Color;

            viewMain.BackgroundColor = GlobalConst.App_Primary_Color;

            viewBG1.BackgroundColor = GlobalConst.App_Primary_Color;
            viewBG2.BackgroundColor = GlobalConst.App_Secondary_Color;
            viewBG3.BackgroundColor = GlobalConst.App_Secondary_Color;
            viewBG4.BackgroundColor = GlobalConst.App_Secondary_Color;
            viewBG5.BackgroundColor = GlobalConst.App_Secondary_Color;
            viewBG6.BackgroundColor = GlobalConst.App_Secondary_Color;

            imgUserProfile.BackgroundColor = GlobalConst.App_Buttons_Color;
            lblUserName.TextColor = GlobalConst.App_Text_Color;
            lblAccountType.TextColor = GlobalConst.App_Text_Color;

            lblTotalScoreTitle.TextColor = GlobalConst.App_Text_Color;
            lblTotalScoreValue.TextColor = GlobalConst.App_Text_Color;
            lblDailyRewardTitle.TextColor = GlobalConst.App_Text_Color;
            progressDailyReward.ProgressTintColor = GlobalConst.App_Buttons_Color;

            lblSeparator1.BackgroundColor = GlobalConst.App_Text_Color;

            imgReferenceCode.TintColor = GlobalConst.App_Text_Color;
            lblReferenceCodeTitle.TextColor = GlobalConst.App_Text_Color;
            lblReferenceCodeValue.TextColor = GlobalConst.App_Text_Color;
            btnReferenceCode.TintColor = GlobalConst.App_Text_Color;
            imgArrow2.TintColor = GlobalConst.App_Text_Color;
            lblSeparator2.BackgroundColor = GlobalConst.App_Text_Color;

            imgEnterCode.TintColor = GlobalConst.App_Text_Color;
            lblEnterCodeTitle.TextColor = GlobalConst.App_Text_Color;
            imgArrow3.TintColor = GlobalConst.App_Text_Color;

            imgGeneralSetting.TintColor = GlobalConst.App_Text_Color;
            lblGeneralSettingTitle.TextColor = GlobalConst.App_Text_Color;
            imgArrow4.TintColor = GlobalConst.App_Text_Color;
            lblSeparator4.BackgroundColor = GlobalConst.App_Text_Color;

            imgJarSetting.TintColor = GlobalConst.App_Text_Color;
            lblJarSettingTitle.TextColor = GlobalConst.App_Text_Color;
            imgArrow5.TintColor = GlobalConst.App_Text_Color;
            lblSeparator5.BackgroundColor = GlobalConst.App_Text_Color;

            imgRecurringTransactions.TintColor = GlobalConst.App_Text_Color;
            lblRecurringTransactionTitle.TextColor = GlobalConst.App_Text_Color;
            lblSeparator6.BackgroundColor = GlobalConst.App_Text_Color;
            imgArrow6.TintColor = GlobalConst.App_Text_Color;

            imgGuide.TintColor = GlobalConst.App_Text_Color;
            lblGuideTitle.TextColor = GlobalConst.App_Text_Color;
            imgArrow7.TintColor = GlobalConst.App_Text_Color;
            lblSeparator7.BackgroundColor = GlobalConst.App_Text_Color;

            imgFAQ.TintColor = GlobalConst.App_Text_Color;
            lblFAQTitle.TextColor = GlobalConst.App_Text_Color;
            imgArrow8.TintColor = GlobalConst.App_Text_Color;

            imgFacebookFan.TintColor = GlobalConst.App_Text_Color;
            lblFacebookFanTitle.TextColor = GlobalConst.App_Text_Color;
            imgArrow9.TintColor = GlobalConst.App_Text_Color;
            lblSeparator9.BackgroundColor = GlobalConst.App_Text_Color;

            imgRating.TintColor = GlobalConst.App_Text_Color;
            lblRatingTitle.TextColor = GlobalConst.App_Text_Color;
            imgArrow10.TintColor = GlobalConst.App_Text_Color;
            lblSeparator10.BackgroundColor = GlobalConst.App_Text_Color;

            lblFeedbackTitle.TextColor = GlobalConst.App_Text_Color;
            imgFeedback.TintColor = GlobalConst.App_Text_Color;
            imgArrow11.TintColor = GlobalConst.App_Text_Color;
            lblSeparator11.BackgroundColor = GlobalConst.App_Text_Color;

            lblTermTitle.TextColor = GlobalConst.App_Text_Color;
            imgTerm.TintColor = GlobalConst.App_Text_Color;
            imgArrow12.TintColor = GlobalConst.App_Text_Color;
            lblSeparator12.BackgroundColor = GlobalConst.App_Text_Color;

            imgInformation.TintColor = GlobalConst.App_Text_Color;
            lblInformationTitle.TextColor = GlobalConst.App_Text_Color;
            imgArrow13.TintColor = GlobalConst.App_Text_Color;
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
            
        }

        partial void btnFAQClicked(UIButton sender)
        {
            FAQsView vc = Storyboard.InstantiateViewController("FAQsView") as FAQsView;
            NavigationController.PushViewController(vc, true);
        }

        partial void btnFacebookFanpageClicked(UIButton sender)
        {
            
        }

        partial void btnRateAppClicked(UIButton sender)
        {
            
        }

        partial void btnFeedbackClicked(UIButton sender)
        {
            
        }

        partial void btnTermClicked(UIButton sender)
        {
            
        }

        partial void btnAppInformationClicked(UIButton sender)
        {
            
        }
    }
}