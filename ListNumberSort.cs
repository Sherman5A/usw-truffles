using System.Collections;

namespace Truffles
{
    public class ListViewNumberSort : IComparer
    {
        public SortOrder OrderSort { get; set; }
        public int SortColumn { get; set; }

        public int Compare(object? x, object? y)
        {
            ListViewItem listViewX = (ListViewItem)x;
            ListViewItem listViewY = (ListViewItem)y;

            bool xIsNumber = int.TryParse(listViewX.SubItems[SortColumn].Text, out int xVal);
            bool yIsNumber = int.TryParse(listViewY.SubItems[SortColumn].Text, out int yVal);

            if (xIsNumber && yIsNumber)
            {
                int compareOutput = xVal.CompareTo(yVal);

                if (OrderSort == SortOrder.Ascending)
                {
                    return compareOutput;
                }
                else if (OrderSort == SortOrder.Descending)
                {
                    return -compareOutput;
                }
                else
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}
