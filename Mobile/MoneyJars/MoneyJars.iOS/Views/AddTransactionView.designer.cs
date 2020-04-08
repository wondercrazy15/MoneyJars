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
    [Register ("AddTransactionView")]
    partial class AddTransactionView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnExpense { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnIncome { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnMoveMoney { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSave { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgArrowConversion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgArrowRight { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgDownArrow1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgDownArrow2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgExpenseCalendar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgExpenseDescription { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgExpenseRepeat { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgFromJar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgIncomeCalendar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgIncomeDescription { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgIncomeRepeat { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgIncomeRightArrow { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgIncomeSelectedJar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgSelectedJar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgToJar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblAddTransactionTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblChangeJarSettingTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCurrentCurrency { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblExpenseSelectedDate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblFromJarTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblIncomeSelectedCurrency { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblIncomeSelectedDate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblIncomeSeparator1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblIncomeSeparator2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblIncomeSeparator3 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblIncomeSeparator4 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSelectAJarTitle1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSelectAJarTitle2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSelectedJarName { get; set; }

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
        UIKit.UILabel lblToJarTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtExpenseAmount { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtIncomeAmount { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView txtViewExpense { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView txtViewIncome { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewBG { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewExpense { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewIncome { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewMoveMoney { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewSwapButton { get; set; }

        [Action ("btnExpenseClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnExpenseClicked (UIKit.UIButton sender);

        [Action ("btnIncomeClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnIncomeClicked (UIKit.UIButton sender);

        [Action ("btnMoveMoneyClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnMoveMoneyClicked (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnExpense != null) {
                btnExpense.Dispose ();
                btnExpense = null;
            }

            if (btnIncome != null) {
                btnIncome.Dispose ();
                btnIncome = null;
            }

            if (btnMoveMoney != null) {
                btnMoveMoney.Dispose ();
                btnMoveMoney = null;
            }

            if (btnSave != null) {
                btnSave.Dispose ();
                btnSave = null;
            }

            if (imgArrowConversion != null) {
                imgArrowConversion.Dispose ();
                imgArrowConversion = null;
            }

            if (imgArrowRight != null) {
                imgArrowRight.Dispose ();
                imgArrowRight = null;
            }

            if (imgDownArrow1 != null) {
                imgDownArrow1.Dispose ();
                imgDownArrow1 = null;
            }

            if (imgDownArrow2 != null) {
                imgDownArrow2.Dispose ();
                imgDownArrow2 = null;
            }

            if (imgExpenseCalendar != null) {
                imgExpenseCalendar.Dispose ();
                imgExpenseCalendar = null;
            }

            if (imgExpenseDescription != null) {
                imgExpenseDescription.Dispose ();
                imgExpenseDescription = null;
            }

            if (imgExpenseRepeat != null) {
                imgExpenseRepeat.Dispose ();
                imgExpenseRepeat = null;
            }

            if (imgFromJar != null) {
                imgFromJar.Dispose ();
                imgFromJar = null;
            }

            if (imgIncomeCalendar != null) {
                imgIncomeCalendar.Dispose ();
                imgIncomeCalendar = null;
            }

            if (imgIncomeDescription != null) {
                imgIncomeDescription.Dispose ();
                imgIncomeDescription = null;
            }

            if (imgIncomeRepeat != null) {
                imgIncomeRepeat.Dispose ();
                imgIncomeRepeat = null;
            }

            if (imgIncomeRightArrow != null) {
                imgIncomeRightArrow.Dispose ();
                imgIncomeRightArrow = null;
            }

            if (imgIncomeSelectedJar != null) {
                imgIncomeSelectedJar.Dispose ();
                imgIncomeSelectedJar = null;
            }

            if (imgSelectedJar != null) {
                imgSelectedJar.Dispose ();
                imgSelectedJar = null;
            }

            if (imgToJar != null) {
                imgToJar.Dispose ();
                imgToJar = null;
            }

            if (lblAddTransactionTitle != null) {
                lblAddTransactionTitle.Dispose ();
                lblAddTransactionTitle = null;
            }

            if (lblChangeJarSettingTitle != null) {
                lblChangeJarSettingTitle.Dispose ();
                lblChangeJarSettingTitle = null;
            }

            if (lblCurrentCurrency != null) {
                lblCurrentCurrency.Dispose ();
                lblCurrentCurrency = null;
            }

            if (lblExpenseSelectedDate != null) {
                lblExpenseSelectedDate.Dispose ();
                lblExpenseSelectedDate = null;
            }

            if (lblFromJarTitle != null) {
                lblFromJarTitle.Dispose ();
                lblFromJarTitle = null;
            }

            if (lblIncomeSelectedCurrency != null) {
                lblIncomeSelectedCurrency.Dispose ();
                lblIncomeSelectedCurrency = null;
            }

            if (lblIncomeSelectedDate != null) {
                lblIncomeSelectedDate.Dispose ();
                lblIncomeSelectedDate = null;
            }

            if (lblIncomeSeparator1 != null) {
                lblIncomeSeparator1.Dispose ();
                lblIncomeSeparator1 = null;
            }

            if (lblIncomeSeparator2 != null) {
                lblIncomeSeparator2.Dispose ();
                lblIncomeSeparator2 = null;
            }

            if (lblIncomeSeparator3 != null) {
                lblIncomeSeparator3.Dispose ();
                lblIncomeSeparator3 = null;
            }

            if (lblIncomeSeparator4 != null) {
                lblIncomeSeparator4.Dispose ();
                lblIncomeSeparator4 = null;
            }

            if (lblSelectAJarTitle1 != null) {
                lblSelectAJarTitle1.Dispose ();
                lblSelectAJarTitle1 = null;
            }

            if (lblSelectAJarTitle2 != null) {
                lblSelectAJarTitle2.Dispose ();
                lblSelectAJarTitle2 = null;
            }

            if (lblSelectedJarName != null) {
                lblSelectedJarName.Dispose ();
                lblSelectedJarName = null;
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

            if (lblToJarTitle != null) {
                lblToJarTitle.Dispose ();
                lblToJarTitle = null;
            }

            if (txtExpenseAmount != null) {
                txtExpenseAmount.Dispose ();
                txtExpenseAmount = null;
            }

            if (txtIncomeAmount != null) {
                txtIncomeAmount.Dispose ();
                txtIncomeAmount = null;
            }

            if (txtViewExpense != null) {
                txtViewExpense.Dispose ();
                txtViewExpense = null;
            }

            if (txtViewIncome != null) {
                txtViewIncome.Dispose ();
                txtViewIncome = null;
            }

            if (viewBG != null) {
                viewBG.Dispose ();
                viewBG = null;
            }

            if (viewExpense != null) {
                viewExpense.Dispose ();
                viewExpense = null;
            }

            if (viewIncome != null) {
                viewIncome.Dispose ();
                viewIncome = null;
            }

            if (viewMoveMoney != null) {
                viewMoveMoney.Dispose ();
                viewMoveMoney = null;
            }

            if (viewSwapButton != null) {
                viewSwapButton.Dispose ();
                viewSwapButton = null;
            }
        }
    }
}