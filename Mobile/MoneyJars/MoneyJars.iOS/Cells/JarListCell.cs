using Foundation;
using MoneyJars.Core.Helper;
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
            lblJarTitle.TextColor = GlobalConst.App_Text_Color;
            lblJarAmount.TextColor = GlobalConst.App_Text_Color;
            progressJarAmount.ProgressTintColor = GlobalConst.App_Buttons_Color;
        }
    }
}