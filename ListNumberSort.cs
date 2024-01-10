using System.Collections;

namespace USWGame
{
    /// <summary>
    /// Sorts ListViewItem containing Integers by ascending or descending
    /// </summary>
    public class ListViewNumberSort : IComparer
    {
        /// <summary>
        /// Sort by ascending or descending
        /// </summary>
        public SortOrder OrderSort { get; set; }

        /// <summary>
        /// The column to sort by
        /// </summary>
        public int SortColumn { get; set; }

        /// <summary>
        /// Compares two ListViewItem objects
        /// </summary>
        /// <param name="x">ListViewItem 1</param>
        /// <param name="y">ListViewItem 2</param>
        /// <returns>Integer representing comparision output
        /// <list type="bullet">
        ///     <item>
        ///         <description>Less than zero - Object <c>x</c> compares less than object <c>y</c></description>
        ///     </item>
        ///     <item>
        ///         <description>Equal to 0 - Object <c>x</c> is equal to object <c>y</c></description>    
        ///     </item>
        ///     <item>
        ///         <description>Greater than 0 - Object <c>x</c> compares greater than object <c>y</c></description>    
        ///     </item>
        /// </list>
        /// </returns>
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
                // Invert if descending as return values are integers from -1 to 1
                else if (OrderSort == SortOrder.Descending)
                {
                    return -compareOutput;
                }
                // If they are equal return 0
                else
                {
                    return 0;
                }
            }
            // Default return if no usable numbers given
            return 1;
        }
    }
}
