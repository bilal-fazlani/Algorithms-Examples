namespace Algorithms._2.Sorting
{
    public class InsertionSort_Old
    {
        public void SortUsingForLoop(int[] values)
        {
            /*
             * PSEUDOCODE - INSERTION SORT - FOR LOOP
             *
             * FOR i = 1, i < length
             *     IF iValue < (i-1)Value
             *         SET j = i
             *         FOR j to 0; j--
             *             IF(jValue < (j-1)Value)
             *                 SWAP(j, j-1)
             */

            for (int i = 1; i < values.Length; i++)
            {
                int currentValue = values[i];
                int previousValue = values[i - 1];
                if (currentValue < previousValue)
                {
                    int j;
                    for (j = i; j > 0; j--)
                    {
                        if (values[j] < values[j - 1])
                        {
                            values.SwapValues(j - 1, j);
                        }
                    }
                }
            }
        }

        public void SortUsingWhileLoop(int[] values)
        {
            /*
             * PSEUDOCODE - INSERTION SORT - WHILE
             * FOR i = 1, i < length
             *     IF iValue < (i-1)Value
             *         SET j = i
             *         WHILE j > 0 & jValue < (j-1)Value
             *             SWAP(j, j-1)
             *             j--
             */

            for (int i = 1; i < values.Length; i++)
            {
                int currentValue = values[i];
                int previousValue = values[i - 1];
                if (currentValue < previousValue)
                {
                    int j = i;
                    while (j > 0 && values[j] < values[j - 1])
                    {
                        values.SwapValues(j-1, j);
                        j--;
                    }
                }
            }
        }
    }
}