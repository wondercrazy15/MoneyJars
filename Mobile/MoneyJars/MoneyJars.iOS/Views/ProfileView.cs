using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.Core.ViewModels;
using MoneyJars.iOS.Views;
using System;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class ProfileView : BaseView<ProfileViewModel>
    {
        public ProfileView (IntPtr handle) : base (handle)
        {
        }

        public ProfileView()
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
            viewMainBG.BackgroundColor = GlobalConst.App_Primary_Color;

            btnBack.TintColor = GlobalConst.App_Text_Color;
            lblProfileTitle.TextColor = GlobalConst.App_Text_Color;
            btnLogOut.TintColor = GlobalConst.App_Buttons_Color;

            imgUserProfile.BackgroundColor = GlobalConst.App_Buttons_Color;
            lblUserName.TextColor = GlobalConst.App_Text_Color;
            lblAccountType.TextColor = GlobalConst.App_Text_Color;

            viewBG1.BackgroundColor = GlobalConst.App_Secondary_Color;

            lblTotalScoreTitle.TextColor = GlobalConst.App_Text_Color;
            lblTotalScoreValue.TextColor = GlobalConst.App_Text_Color;

            lblSeparator1.BackgroundColor = GlobalConst.App_Text_Color;

            lblDailyProgressTitle.TextColor = GlobalConst.App_Text_Color;
            progressDailyProgress.ProgressTintColor = GlobalConst.App_Buttons_Color;

            viewBG2.BackgroundColor = GlobalConst.App_Secondary_Color;

            lblExperienceScoreTitle.TextColor = GlobalConst.App_Text_Color;
            lblExperienceLevel.TextColor = GlobalConst.App_Text_Color;
            lblSeparator2.BackgroundColor = GlobalConst.App_Text_Color;
            imgExperienceScore.TintColor = GlobalConst.App_Text_Color;
            progressExperienceScore.ProgressTintColor = GlobalConst.App_Buttons_Color;

            lblFutureScoreTitle.TextColor = GlobalConst.App_Text_Color;
            lblFutureLevel.TextColor = GlobalConst.App_Text_Color;
            imgFuture.TintColor = GlobalConst.App_Text_Color;
            progressFuture.ProgressTintColor = GlobalConst.App_Buttons_Color;
            lblSeparator3.BackgroundColor = GlobalConst.App_Text_Color;

            lblInspiringScoreTitle.TextColor = GlobalConst.App_Text_Color;
            lblInspiringLevel.TextColor = GlobalConst.App_Text_Color;
            imgInspiring.TintColor = GlobalConst.App_Text_Color;
            progressInspiring.ProgressTintColor = GlobalConst.App_Buttons_Color;


        }

        partial void btnBackClicked(UIButton sender)
        {
            NavigationController.PopViewController(true);
        }

        partial void btnLogoutClicked(UIButton sender)
        {
            
        }
    }
}