using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace Table01
{
    public class MyCell : UITableViewCell
    {
        public MyCell(IntPtr p) : base(p)
        {
            this.TextLabel.Text = "()";
        }
        public void SetText(string text)
        {
            this.TextLabel.Text = text;
        }
    }
}