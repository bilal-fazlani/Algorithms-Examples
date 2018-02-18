namespace Algorithms._2.Sorting
{
    /// <summary>
    /// Complexity - O(n)^2
    /// </summary>
    public class BubbleSort
    {
        public void Sort(int[] values)
        {
            /*
             * PSEUDOCODE - BUBBLE SORT
             *
             * LOOP
             *     SET swappedAtLeastOnce = false
             *     FOR(i:0  --> i<len-1)
             *         if(swap required)
             *             swap()
             *             SET swappedAtLeastOnce true
             * WHILE swappedAtLeastOnce == true
             */
            
            int length = values.Length;

            bool swappedAtLeastOnce = false;
            
            do
            {
                swappedAtLeastOnce = false;
                for (int i = 0; i < length - 1; i++)
                {
                    if (SwapRequired(values, i, i + 1))
                    {
                        values.SwapValues(i, i + 1);
                        swappedAtLeastOnce = true;
                    }
                }
            } while (swappedAtLeastOnce);
        }

        private static bool SwapRequired(int[] values, int position1, int position2)
        {
            return values[position1] > values[position2];
        }
    }
}