using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.iOS.Helper;
using System;
using System.Collections.Generic;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class WalkThroughCell : UICollectionViewCell
    {
        public WalkThroughCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(Dictionary<string, string> data)
        {
            lblTitle.TextColor = Constants.App_Text_Color;
            lblMessage.TextColor = Constants.App_Text_Color;

            lblTitle.Text = data["Title"];
            lblMessage.Text = data["Message"];
        }
    }
}