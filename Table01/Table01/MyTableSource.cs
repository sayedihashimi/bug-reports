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
            /*
             * UITableViewCell cell = tableView.DequeueReusableCell (CellIdentifier);
            string item = TableItems[indexPath.Row];

            //---- if there are no cells to reuse, create a new one
            if (cell == null)
            { cell = new UITableViewCell (UITableViewCellStyle.Default, CellIdentifier); }

            cell.TextLabel.Text = item;

            return cell;
             */

            var cell = tableView.DequeueReusableCell("tablecell");
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