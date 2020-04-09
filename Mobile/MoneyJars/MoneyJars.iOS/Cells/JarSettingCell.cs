using Foundation;
using MoneyJars.Core.Helper;
using System;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class JarSettingCell : UITableViewCell
    {
        public JarSettingCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(string data)
        {
            lblJarTitle.TextColor = GlobalConst.App_Text_Color;
            lblJarPercentage.TextColor = GlobalConst.App_Buttons_Color;
            lblJarPercentage.BackgroundColor = GlobalConst.App_Secondary_Color;

            btnIncrease.TintColor = GlobalConst.App_Text_Color;
            btnDecrease.TintColor = GlobalConst.App_Text_Color;
        }

        partial void btnDecreaseClicked(UIButton sender)
        {
            if(Convert.ToInt32(lblJarPercentage.Text) == 0)
            {
                return;
            }
            lblJarPercentage.Text = (Convert.ToInt32(lblJarPercentage.Text)-1).ToString();
        }

        partial void btnIncreaseClicked(UIButton sender)
        {
            if (Convert.ToInt32(lblJarPercentage.Text) == 100)
            {
                return;
            }
            lblJarPercentage.Text = (Convert.ToInt32(lblJarPercentage.Text) + 1).ToString();
        }
    }
}