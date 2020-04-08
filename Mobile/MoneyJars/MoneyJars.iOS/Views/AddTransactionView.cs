using Foundation;
using MoneyJars.Core.Helper;
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


            btnIncome.BackgroundColor = GlobalConst.App_Green_Color;
            btnExpense.BackgroundColor = UIColor.Clear;
            btnMoveMoney.BackgroundColor = UIColor.Clear;

            viewIncome.Hidden = false;
            viewExpense.Hidden = true;
            viewMoveMoney.Hidden = true;
        }

        private void SetColors()
        {

            viewBG.BackgroundColor = GlobalConst.App_Primary_Color;

            lblAddTransactionTitle.TextColor = GlobalConst.App_Text_Color;
            btnSave.SetTitleColor(GlobalConst.App_Text_Color, UIControlState.Normal);

            viewSwapButton.BackgroundColor = GlobalConst.App_Extra_Space_Color;
            viewSwapButton.Layer.BorderColor = GlobalConst.App_Secondary_Color.CGColor;
            viewSwapButton.Layer.BorderWidth = 1.5f;

            btnIncome.SetTitleColor(GlobalConst.App_Text_Color, UIControlState.Normal);
            btnExpense.SetTitleColor(GlobalConst.App_Text_Color, UIControlState.Normal);
            btnMoveMoney.SetTitleColor(GlobalConst.App_Text_Color, UIControlState.Normal);

            viewIncome.BackgroundColor = GlobalConst.App_Secondary_Color;
            viewExpense.BackgroundColor = GlobalConst.App_Secondary_Color;
            viewMoveMoney.BackgroundColor = GlobalConst.App_Secondary_Color;

            lblFromJarTitle.TextColor = GlobalConst.App_Text_Color;
            imgFromJar.TintColor = GlobalConst.App_Text_Color;
            imgDownArrow1.TintColor = GlobalConst.App_Text_Color;
            lblSelectAJarTitle1.TextColor = GlobalConst.App_Text_Color;

            lblToJarTitle.TextColor = GlobalConst.App_Text_Color;
            imgToJar.TintColor = GlobalConst.App_Text_Color;
            imgDownArrow2.TintColor = GlobalConst.App_Text_Color;
            lblSelectAJarTitle2.TextColor = GlobalConst.App_Text_Color;

            imgArrowConversion.TintColor = GlobalConst.App_Buttons_Color;

            lblCurrentCurrency.TextColor = GlobalConst.App_Buttons_Color;
            lblCurrentCurrency.BackgroundColor = GlobalConst.App_Primary_Color;
            lblSeparator1.BackgroundColor = GlobalConst.App_Text_Color;
            txtExpenseAmount.TextColor = GlobalConst.App_Text_Color;
            txtExpenseAmount.TintColor = GlobalConst.App_Buttons_Color;

            imgSelectedJar.TintColor = GlobalConst.App_Text_Color;
            lblSelectedJarName.TextColor = GlobalConst.App_Text_Color;
            imgArrowRight.TintColor = GlobalConst.App_Text_Color;
            lblSeparator2.BackgroundColor = GlobalConst.App_Text_Color;

            imgExpenseCalendar.TintColor = GlobalConst.App_Text_Color;
            lblExpenseSelectedDate.TextColor = GlobalConst.App_Text_Color;
            imgExpenseRepeat.TintColor = GlobalConst.App_Text_Color;
            lblSeparator3.BackgroundColor = GlobalConst.App_Text_Color;

            imgExpenseDescription.TintColor = GlobalConst.App_Text_Color;
            txtViewExpense.TextColor = GlobalConst.App_Text_Color;
            lblSeparator4.BackgroundColor = GlobalConst.App_Text_Color;

            txtIncomeAmount.TextColor = GlobalConst.App_Text_Color;
            lblIncomeSeparator1.BackgroundColor = GlobalConst.App_Text_Color;
            lblIncomeSelectedCurrency.TextColor = GlobalConst.App_Buttons_Color;
            lblIncomeSelectedCurrency.BackgroundColor = GlobalConst.App_Primary_Color;

            imgIncomeSelectedJar.TintColor = GlobalConst.App_Text_Color;
            lblChangeJarSettingTitle.TextColor = GlobalConst.App_Text_Color;
            imgIncomeRightArrow.TintColor = GlobalConst.App_Text_Color;
            lblIncomeSeparator2.BackgroundColor = GlobalConst.App_Text_Color;

            imgIncomeCalendar.TintColor = GlobalConst.App_Text_Color;
            lblIncomeSelectedDate.TextColor = GlobalConst.App_Text_Color;
            imgIncomeRepeat.TintColor = GlobalConst.App_Text_Color;
            lblIncomeSeparator3.BackgroundColor = GlobalConst.App_Text_Color;

            imgIncomeDescription.TintColor = GlobalConst.App_Text_Color;
            txtViewIncome.TextColor = GlobalConst.App_Text_Color;
            lblIncomeSeparator4.BackgroundColor = GlobalConst.App_Text_Color;




        }

        partial void btnIncomeClicked(UIButton sender)
        {
            btnIncome.BackgroundColor = GlobalConst.App_Green_Color;
            btnExpense.BackgroundColor = UIColor.Clear;
            btnMoveMoney.BackgroundColor = UIColor.Clear;

            viewIncome.Hidden = false;
            viewExpense.Hidden = true;
            viewMoveMoney.Hidden = true;
        }

        partial void btnExpenseClicked(UIButton sender)
        {
            btnIncome.BackgroundColor = UIColor.Clear;
            btnExpense.BackgroundColor = GlobalConst.App_Red_Color;
            btnMoveMoney.BackgroundColor = UIColor.Clear;

            viewIncome.Hidden = true;
            viewExpense.Hidden = false;
            viewMoveMoney.Hidden = true;
        }

        partial void btnMoveMoneyClicked(UIButton sender)
        {
            btnIncome.BackgroundColor = UIColor.Clear;
            btnExpense.BackgroundColor = UIColor.Clear;
            btnMoveMoney.BackgroundColor = GlobalConst.App_Buttons_Color;

            viewIncome.Hidden = true;
            viewExpense.Hidden = true;
            viewMoveMoney.Hidden = false;
        }
    }
}