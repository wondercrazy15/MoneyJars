using Foundation;
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
            lblTitle.Text = data["Title"];
            lblMessage.Text = data["Message"];
        }
    }
}