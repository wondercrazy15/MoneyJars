using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.Core.ViewModels;
using MoneyJars.iOS.Helper;
using MoneyJars.iOS.Views;
using System;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class PasscodeView : BaseView<PasscodeViewModel>
    {
        public PasscodeView (IntPtr handle) : base (handle)
        {
        }

        public PasscodeView()
        {
        }

        public override void ViewDidLoad()
        {
            SetColors();

        }

        private void SetColors()
        {
            viewExtraSpace.BackgroundColor = Constants.App_Extra_Space_Color;

            viewMain.BackgroundColor = Constants.App_Primary_Color;

        }

        partial void btnBackClicked(UIButton sender)
        {
            DismissViewController(true, null);
        }


        private void AddText(string strValue)
        {
            if (txtPasscode1.Text.Length == 0)
            {
                txtPasscode1.Text = strValue;
                return;
            }

            if (txtPasscode2.Text.Length == 0)
            {
                txtPasscode2.Text = strValue;
                return;
            }

            if (txtPasscode3.Text.Length == 0)
            {
                txtPasscode3.Text = strValue;
                return;
            }

            if (txtPasscode4.Text.Length == 0)
            {
                txtPasscode4.Text = strValue;
                _ = GlobalMethod.DelayedMethod(500, () =>
                {

                });
                return;
            }
        }

        partial void btn1Clicked(UIButton sender)
        {
            AddText("1");
        }

        partial void btn2Clicked(UIButton sender)
        {
            AddText("2");
        }

        partial void btn3Clicked(UIButton sender)
        {
            AddText("3");
        }

        partial void btn4Clicked(UIButton sender)
        {
            AddText("4");
        }

        partial void btn5Clicked(UIButton sender)
        {
            AddText("5");
        }

        partial void btn6Clicked(UIButton sender)
        {
            AddText("6");
        }

        partial void btn7Clicked(UIButton sender)
        {
            AddText("7");
        }

        partial void btn8Clicked(UIButton sender)
        {
            AddText("8");
        }

        partial void btn9Clicked(UIButton sender)
        {
            AddText("9");
        }

        partial void btn0Clicked(UIButton sender)
        {
            AddText("0");
        }

        partial void btnEraseClicked(UIButton sender)
        {
            string value = txtPasscode1.Text + txtPasscode2.Text + txtPasscode3.Text + txtPasscode4.Text;
            switch (value.Length)
            {
                case 1:
                    txtPasscode1.Text = "";
                    break;

                case 2:
                    txtPasscode2.Text = "";
                    break;

                case 3:
                    txtPasscode3.Text = "";
                    break;

                case 4:
                    txtPasscode4.Text = "";
                    break;

                default:
                    break;
            }

        }

    }
}