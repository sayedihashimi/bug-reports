using Foundation;
using System;
using UIKit;

namespace Table01
{
    public partial class MyTableViewController : UITableViewController
    {
        public MyTableViewController (IntPtr handle) : base (handle)
        {
            TableView.RegisterClassForCellReuse(typeof(UITableViewCell), "tablecell");
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            TableView.Source = new MyTableSource();
        }
    }
}