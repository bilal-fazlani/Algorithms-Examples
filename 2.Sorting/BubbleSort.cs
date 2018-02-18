namespace Algorithms._2.Sorting
{
    public class BubbleSort :ISort
    {
        public int[] Sort(int[] values)
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
                        Swap(values, i, i + 1);
                        swappedAtLeastOnce = true;
                    }
                }
            } while (swappedAtLeastOnce);

            return values;
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