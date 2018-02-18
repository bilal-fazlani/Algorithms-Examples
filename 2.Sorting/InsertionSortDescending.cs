namespace Algorithms._2.Sorting
{
    public class InsertionSortDescending
    {
        public void SortDescending(int[] values)
        {
            /*
             * INSERTION SORT DESCENDING - PSEUDO CODE
             * 
             * FOR i = 1 to i < length
             *     IF currentValue > previousValue
             *         SET j = i
             *         WHILE j > 0 & jValue > (j-1)Value
             *             SWAP(j-1, j)
             *             j--
             */

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > values[i - 1])
                {
                    int j = i; 
                    while (j > 0 && values[j] > values[j-1])
                    {
                        values.SwapValues(j, j-1);
                        j--;
                    }
                }
            }
        }
    }
}