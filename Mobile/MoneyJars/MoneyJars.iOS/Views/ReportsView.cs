using Foundation;
using System;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class ReportsView : UIViewController
    {
        public ReportsView (IntPtr handle) : base (handle)
        {
        }


        public override UIStatusBarStyle PreferredStatusBarStyle()
        {
            return UIStatusBarStyle.LightContent;
        }
    }
}