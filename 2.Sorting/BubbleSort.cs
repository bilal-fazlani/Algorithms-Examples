namespace Algorithms._2.Sorting
{
    public class BubbleSort :ISort
    {
        public void Sort(int[] values)
        {
            /*
             * PSEUDOCODE - BUBBLE SORT
             * -------------------------
             *
             * 
             * LOOP
             *     SET swapped = false
             *     FOR i = 0 to lenth-1
             *         IF SWAP required
             *             SWAP
             *             SET swapped = true
             * WHILE swapped == true
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
                        Swap(values, i, i + 1);
                        swappedAtLeastOnce = true;
                    }
                }
            } while (swappedAtLeastOnce);
        }

        private static bool SwapRequired(int[] values, int position1, int position2)
        {
            return values[position1] > values[position2];
        }
        
        private static void Swap(int[]values, int position1, int position2)
        {
            int valueAtPosition1 = values[position1];
            values[position1] = values[position2];
            values[position2] = valueAtPosition1;
        }
    }
}