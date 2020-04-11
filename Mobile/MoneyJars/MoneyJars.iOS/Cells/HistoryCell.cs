using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.iOS.Helper;
using System;
using System.Collections.Generic;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class HistoryCell : UITableViewCell
    {
        public HistoryCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(string data)
        {
            lblHistoryAmount.TextColor = Constants.App_Green_Color;

            lblHistoryTitle.TextColor = Constants.App_Text_Color;
            lblHistoryMessage.TextColor = Constants.App_Text_Color;
            lblHistoryDate.TextColor = Constants.App_Text_Color;
        }
    }
}