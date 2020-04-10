﻿using System;
using UIKit;

namespace MoneyJars.Core.Helper
{
    public static class GlobalConst
    {
        //API End Points
        public static string BaseUrl = "http://";

        public static string UserLogin = "User/LogIn";

        public static string FAQsUrl = "https://moneyoi.io/pages/frequent-asked-questions";
        public static string TermsUrl = "https://moneyoi.io/blogs/moneyoi-quan-ly-6-hu-en/moneyoi-app-privacy-policy";
        public static string FacebookUrl = "https://www.facebook.com/MoneyOiApp";
        public static string iTunesUrl = "itms://itunes.apple.com/app/apple-store/id375380948?mt=8";


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
