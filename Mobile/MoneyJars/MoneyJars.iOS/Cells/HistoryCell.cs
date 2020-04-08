using Foundation;
using MoneyJars.Core.Helper;
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
            lblHistoryAmount.TextColor = GlobalConst.App_Green_Color;

            lblHistoryTitle.TextColor = GlobalConst.App_Text_Color;
            lblHistoryMessage.TextColor = GlobalConst.App_Text_Color;
            lblHistoryDate.TextColor = GlobalConst.App_Text_Color;
        }
    }
}