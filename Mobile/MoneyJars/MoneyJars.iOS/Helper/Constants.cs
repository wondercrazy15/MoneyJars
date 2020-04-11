using System;
using UIKit;

namespace MoneyJars.iOS.Helper
{
    public static class Constants
    {
        //Changes on iOS
        public static int ScreenWidth = Convert.ToInt32(UIScreen.MainScreen.Bounds.Width);
        public static int ScreenHeight = Convert.ToInt32(UIScreen.MainScreen.Bounds.Height);

        public static UIColor App_Primary_Color = UIColor.FromRGB(21.0f / 255.0f, 36.0f / 255.0f, 48.0f / 255.0f);
        public static UIColor App_Secondary_Color = UIColor.FromRGB(33.0f / 255.0f, 49.0f / 255.0f, 59.0f / 255.0f);
        public static UIColor App_Buttons_Color = UIColor.FromRGB(0.0f / 255.0f, 186.0f / 255.0f, 181.0f / 255.0f);
        public static UIColor App_Text_Color = UIColor.White;
        public static UIColor App_Extra_Space_Color = UIColor.Black;

        public static UIColor App_Green_Color = UIColor.SystemGreenColor;
        public static UIColor App_Red_Color = UIColor.FromRGB(250.0f / 255.0f, 59.0f / 255.0f, 86.0f / 255.0f);

    }
}
