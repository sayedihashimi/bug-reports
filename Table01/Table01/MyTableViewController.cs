using Foundation;
using System;
using UIKit;

namespace Table01
{
    public partial class MyTableViewController : UITableViewController
    {
        public MyTableViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            tableView.Source = new MyTableSource();
        }
    }
}