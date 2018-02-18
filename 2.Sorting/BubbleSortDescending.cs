namespace Algorithms._2.Sorting
{
    public class BubbleSortDescending : ISort
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
                        Swap(values, i, i + 1);
                        swappedAtLeastOnce = true;
                    }
                }
            } while (swappedAtLeastOnce);
        }

        private bool IsSwapRequired(int[] values, int position1, int position2)
        {
            return values[position1] < values[position2];
        }
        
        private void Swap(int[] values, int position1, int position2)
        {
            int position1Value = values[position1];

            values[position1] = values[position2];
            values[position2] = position1Value;
        }
    }
}