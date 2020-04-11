using Foundation;
using MoneyJars.Core.Helper;
using MoneyJars.iOS.Helper;
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

            viewBackGround.BackgroundColor = Constants.App_Primary_Color;
            lblCurrencyTitle.TextColor = Constants.App_Text_Color;
            lblCurrencyName.TextColor = Constants.App_Text_Color;
        }
    }
}