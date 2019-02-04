using System.Collections;
using System.Windows.Forms;

namespace AllInOne.Logic
{
    public class ColumnSorterAsc:IComparer
    {
        private int ColumnToSort;
        private CaseInsensitiveComparer sensComparer;
        public int Compare(object one, object two)
        {
            ListViewItem oneLvi = (ListViewItem)one;
            ListViewItem twoLvi = (ListViewItem)two;

            return sensComparer.Compare(oneLvi.SubItems[ColumnToSort].Text, twoLvi.SubItems[ColumnToSort].Text);
        }
        public ColumnSorterAsc()
        {
            ColumnToSort = 0;
            sensComparer = new CaseInsensitiveComparer();
        }
        public int SortColumn
        {
            set
            {
                ColumnToSort = value;
            }
            get
            {
                return ColumnToSort;
            }
        }
    }
}
