using System;
using MoneyJars.Core.Helper;
using UIKit;

namespace MoneyJars.iOS.Helper
{
    public static class Methods
    {

        static UIAlertController alert;
        public static void ShowAlert(string message, UIViewController view, Action OkAction)
        {
            alert = UIAlertController.Create("NatRIX Place", message, UIAlertControllerStyle.Alert);
            //Add Actions
            alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, alert => {
                OkAction();
            }));

            //alert.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, alert => Console.WriteLine("Cancel was clicked")));

            view.PresentViewController(alert, true, null);

            _ = GlobalMethod.DelayedMethod(1500, () =>
            {
                alert.DismissViewController(true, null);
            });

        }


        public static void addShadow(UIView view, int radius)
        {
            view.Layer.CornerRadius = radius;
            view.Layer.MasksToBounds = false;
            view.Layer.ShadowColor = UIColor.Gray.CGColor;
            view.Layer.ShadowOffset = new CoreGraphics.CGSize(0f, 2f);
            view.Layer.ShadowOpacity = (float)0.5;

        }


    }
}
