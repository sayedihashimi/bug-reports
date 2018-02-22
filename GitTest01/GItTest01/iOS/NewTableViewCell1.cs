using System;

using Foundation;
using UIKit;

namespace GItTest01.iOS
{
    public partial class NewTableViewCell1 : UITableViewCell
    {
        public static readonly NSString Key = new NSString("NewTableViewCell1");
        public static readonly UINib Nib;

        static NewTableViewCell1()
        {
            Nib = UINib.FromName("NewTableViewCell1", NSBundle.MainBundle);
        }

        protected NewTableViewCell1(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
