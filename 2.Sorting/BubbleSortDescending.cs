namespace Algorithms._2.Sorting
{
    public class BubbleSortDescending
    {
        public void Sort(int[] values)
        {
            /*
             * PSEUDOCODE - BUBBLE SORT DESCENDING
             *
             * LOOP
             *     SET swappedAtLeastOnce = false
             *     FOR(i:0  --> i<len-1)
             *         if(swap required)
             *             swap()
             *             SET swappedAtLeastOnce true
             * WHILE swappedAtLeastOnce == true
             */

            bool swappedAtLeastOnce;
            do
            {
                swappedAtLeastOnce = false;
                for (int i = 0; i < values.Length - 1; i++)
                {
                    if (IsSwapRequired(values, i, i + 1))
                    {
                        values.SwapValues(i, i + 1);
                        swappedAtLeastOnce = true;
                    }
                }
            } while (swappedAtLeastOnce);
        }

        /// <summary>
        /// Only this method logic is different in ascending and descending
        /// </summary>
        /// <param name="values"></param>
        /// <param name="position1"></param>
        /// <param name="position2"></param>
        /// <returns></returns>
        private bool IsSwapRequired(int[] values, int position1, int position2)
        {
            return values[position1] < values[position2];
        }
    }
}