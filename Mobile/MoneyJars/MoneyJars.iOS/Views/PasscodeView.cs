using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.Core.ViewModels;
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
            viewExtraSpace.BackgroundColor = GlobalConst.App_Extra_Space_Color;

            viewMain.BackgroundColor = GlobalConst.App_Primary_Color;

        }

        partial void btnBackClicked(UIButton sender)
        {
            DismissViewController(true, null);
        }


        partial void btn1Clicked(UIButton sender)
        {
            
        }

        partial void btn2Clicked(UIButton sender)
        {
            
        }

        partial void btn3Clicked(UIButton sender)
        {
            
        }

        partial void btn4Clicked(UIButton sender)
        {
            
        }

        partial void btn5Clicked(UIButton sender)
        {
            
        }

        partial void btn6Clicked(UIButton sender)
        {
            
        }

        partial void btn7Clicked(UIButton sender)
        {
            
        }

        partial void btn8Clicked(UIButton sender)
        {
            
        }

        partial void btn9Clicked(UIButton sender)
        {
            
        }

        partial void btn0Clicked(UIButton sender)
        {
            
        }

        partial void btnEraseClicked(UIButton sender)
        {
            
        }

    }
}