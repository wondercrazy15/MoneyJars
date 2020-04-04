using Foundation;
using MoneyJars.Core.Helper;
using System;
using UIKit;

namespace MoneyJars.iOS
{
    public partial class CurrencyListCell : UITableViewCell
    {
        public CurrencyListCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell(System.Collections.Generic.Dictionary<string, string> data)
        {
            lblCurrencyTitle.Text = data["Title"];
            lblCurrencyName.Text = data["Name"];

            viewBackGround.BackgroundColor = GlobalConst.App_Primary_Color;
            lblCurrencyTitle.TextColor = GlobalConst.App_Text_Color;
            lblCurrencyName.TextColor = GlobalConst.App_Text_Color;
        }
    }
}