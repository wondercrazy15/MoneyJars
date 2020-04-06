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

        private void SetColors()
        {
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
    }
}