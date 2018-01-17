using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace Table01
{
    public class MyTableSource : UITableViewSource
    {
        private List<string> Data = new List<string>
        {
            "one",
            "two",
            "three",
            "four"
        };
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("tablecell",indexPath);
            if(cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, "tablecell");
            }

            cell.TextLabel.Text = Data.ElementAt(indexPath.Row);
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return Data.Count;
        }

    }
}