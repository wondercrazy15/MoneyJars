using System;
using UIKit;

namespace MoneyJars.Core.Helper
{
    public static class GlobalConst
    {
        //API End Points
        public static string BaseUrl = "http://";

        public static string UserLogin = "User/LogIn";
        

        public static int ScreenWidth = Convert.ToInt32(UIScreen.MainScreen.Bounds.Width);
        public static int ScreenHeight = Convert.ToInt32(UIScreen.MainScreen.Bounds.Height);


    }
}
