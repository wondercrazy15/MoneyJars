using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.iOS.Helper;
using System;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class JarListCell : UITableViewCell
    {
        public JarListCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(string data)
        {
            lblJarTitle.TextColor = Constants.App_Text_Color;
            lblJarAmount.TextColor = Constants.App_Text_Color;
            progressJarAmount.ProgressTintColor = Constants.App_Buttons_Color;
        }
    }
}