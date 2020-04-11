using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.iOS.Helper;
using System;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class AddTransactionView : UIViewController
    {
        public AddTransactionView (IntPtr handle) : base (handle)
        {
        }

        public AddTransactionView()
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

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            btnIncome.Layer.CornerRadius = btnIncome.Frame.Size.Height / 2;
            btnExpense.Layer.CornerRadius = btnExpense.Frame.Size.Height / 2;
            btnMoveMoney.Layer.CornerRadius = btnMoveMoney.Frame.Size.Height / 2;


            btnIncome.BackgroundColor = Constants.App_Green_Color;
            btnExpense.BackgroundColor = UIColor.Clear;
            btnMoveMoney.BackgroundColor = UIColor.Clear;

            viewIncome.Hidden = false;
            viewExpense.Hidden = true;
            viewMoveMoney.Hidden = true;
        }

        private void SetColors()
        {

            viewBG.BackgroundColor = Constants.App_Primary_Color;

            lblAddTransactionTitle.TextColor = Constants.App_Text_Color;
            btnSave.SetTitleColor(Constants.App_Text_Color, UIControlState.Normal);

            viewSwapButton.BackgroundColor = Constants.App_Extra_Space_Color;
            viewSwapButton.Layer.BorderColor = Constants.App_Secondary_Color.CGColor;
            viewSwapButton.Layer.BorderWidth = 1.5f;

            btnIncome.SetTitleColor(Constants.App_Text_Color, UIControlState.Normal);
            btnExpense.SetTitleColor(Constants.App_Text_Color, UIControlState.Normal);
            btnMoveMoney.SetTitleColor(Constants.App_Text_Color, UIControlState.Normal);

            viewIncome.BackgroundColor = Constants.App_Secondary_Color;
            viewExpense.BackgroundColor = Constants.App_Secondary_Color;
            viewMoveMoney.BackgroundColor = Constants.App_Secondary_Color;

            lblFromJarTitle.TextColor = Constants.App_Text_Color;
            imgFromJar.TintColor = Constants.App_Text_Color;
            imgDownArrow1.TintColor = Constants.App_Text_Color;
            lblSelectAJarTitle1.TextColor = Constants.App_Text_Color;

            lblToJarTitle.TextColor = Constants.App_Text_Color;
            imgToJar.TintColor = Constants.App_Text_Color;
            imgDownArrow2.TintColor = Constants.App_Text_Color;
            lblSelectAJarTitle2.TextColor = Constants.App_Text_Color;

            imgArrowConversion.TintColor = Constants.App_Buttons_Color;

            lblCurrentCurrency.TextColor = Constants.App_Buttons_Color;
            lblCurrentCurrency.BackgroundColor = Constants.App_Primary_Color;
            lblSeparator1.BackgroundColor = Constants.App_Text_Color;
            txtExpenseAmount.TextColor = Constants.App_Text_Color;
            txtExpenseAmount.TintColor = Constants.App_Buttons_Color;

            imgSelectedJar.TintColor = Constants.App_Text_Color;
            lblSelectedJarName.TextColor = Constants.App_Text_Color;
            imgArrowRight.TintColor = Constants.App_Text_Color;
            lblSeparator2.BackgroundColor = Constants.App_Text_Color;

            imgExpenseCalendar.TintColor = Constants.App_Text_Color;
            lblExpenseSelectedDate.TextColor = Constants.App_Text_Color;
            imgExpenseRepeat.TintColor = Constants.App_Text_Color;
            lblSeparator3.BackgroundColor = Constants.App_Text_Color;

            imgExpenseDescription.TintColor = Constants.App_Text_Color;
            txtViewExpense.TextColor = Constants.App_Text_Color;
            lblSeparator4.BackgroundColor = Constants.App_Text_Color;

            txtIncomeAmount.TextColor = Constants.App_Text_Color;
            lblIncomeSeparator1.BackgroundColor = Constants.App_Text_Color;
            lblIncomeSelectedCurrency.TextColor = Constants.App_Buttons_Color;
            lblIncomeSelectedCurrency.BackgroundColor = Constants.App_Primary_Color;

            imgIncomeSelectedJar.TintColor = Constants.App_Text_Color;
            lblChangeJarSettingTitle.TextColor = Constants.App_Text_Color;
            imgIncomeRightArrow.TintColor = Constants.App_Text_Color;
            lblIncomeSeparator2.BackgroundColor = Constants.App_Text_Color;

            imgIncomeCalendar.TintColor = Constants.App_Text_Color;
            lblIncomeSelectedDate.TextColor = Constants.App_Text_Color;
            imgIncomeRepeat.TintColor = Constants.App_Text_Color;
            lblIncomeSeparator3.BackgroundColor = Constants.App_Text_Color;

            imgIncomeDescription.TintColor = Constants.App_Text_Color;
            txtViewIncome.TextColor = Constants.App_Text_Color;
            lblIncomeSeparator4.BackgroundColor = Constants.App_Text_Color;




        }

        partial void btnIncomeClicked(UIButton sender)
        {
            btnIncome.BackgroundColor = Constants.App_Green_Color;
            btnExpense.BackgroundColor = UIColor.Clear;
            btnMoveMoney.BackgroundColor = UIColor.Clear;

            viewIncome.Hidden = false;
            viewExpense.Hidden = true;
            viewMoveMoney.Hidden = true;
        }

        partial void btnExpenseClicked(UIButton sender)
        {
            btnIncome.BackgroundColor = UIColor.Clear;
            btnExpense.BackgroundColor = Constants.App_Red_Color;
            btnMoveMoney.BackgroundColor = UIColor.Clear;

            viewIncome.Hidden = true;
            viewExpense.Hidden = false;
            viewMoveMoney.Hidden = true;
        }

        partial void btnMoveMoneyClicked(UIButton sender)
        {
            btnIncome.BackgroundColor = UIColor.Clear;
            btnExpense.BackgroundColor = UIColor.Clear;
            btnMoveMoney.BackgroundColor = Constants.App_Buttons_Color;

            viewIncome.Hidden = true;
            viewExpense.Hidden = true;
            viewMoveMoney.Hidden = false;
        }
    }
}