using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.Core.ViewModels;
using MoneyJars.iOS.Helper;
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
            viewExtraSpace.BackgroundColor = Constants.App_Extra_Space_Color;
            viewMainBG.BackgroundColor = Constants.App_Primary_Color;

            btnBack.TintColor = Constants.App_Text_Color;
            lblProfileTitle.TextColor = Constants.App_Text_Color;
            btnLogOut.TintColor = Constants.App_Buttons_Color;

            imgUserProfile.BackgroundColor = Constants.App_Buttons_Color;
            lblUserName.TextColor = Constants.App_Text_Color;
            lblAccountType.TextColor = Constants.App_Text_Color;

            viewBG1.BackgroundColor = Constants.App_Secondary_Color;

            lblTotalScoreTitle.TextColor = Constants.App_Text_Color;
            lblTotalScoreValue.TextColor = Constants.App_Text_Color;

            lblSeparator1.BackgroundColor = Constants.App_Text_Color;

            lblDailyProgressTitle.TextColor = Constants.App_Text_Color;
            progressDailyProgress.ProgressTintColor = Constants.App_Buttons_Color;

            viewBG2.BackgroundColor = Constants.App_Secondary_Color;

            lblExperienceScoreTitle.TextColor = Constants.App_Text_Color;
            lblExperienceLevel.TextColor = Constants.App_Text_Color;
            lblSeparator2.BackgroundColor = Constants.App_Text_Color;
            imgExperienceScore.TintColor = Constants.App_Text_Color;
            progressExperienceScore.ProgressTintColor = Constants.App_Buttons_Color;

            lblFutureScoreTitle.TextColor = Constants.App_Text_Color;
            lblFutureLevel.TextColor = Constants.App_Text_Color;
            imgFuture.TintColor = Constants.App_Text_Color;
            progressFuture.ProgressTintColor = Constants.App_Buttons_Color;
            lblSeparator3.BackgroundColor = Constants.App_Text_Color;

            lblInspiringScoreTitle.TextColor = Constants.App_Text_Color;
            lblInspiringLevel.TextColor = Constants.App_Text_Color;
            imgInspiring.TintColor = Constants.App_Text_Color;
            progressInspiring.ProgressTintColor = Constants.App_Buttons_Color;


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