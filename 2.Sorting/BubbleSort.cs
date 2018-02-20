namespace Algorithms._2.Sorting
{
    public class BubbleSort : ISortingAlgorithm
    {
        public void SortAscending(int[] values)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < values.Length-1; i++)
                {
                    if (values[i] > values[i + 1])
                    {
                        values.SwapValues(i, i +1);
                        swapped = true;
                    }
                }

            } while (swapped);
        }
        
        public void SortDescending(int[] values)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < values.Length-1; i++)
                {
                    if (values[i] < values[i + 1])
                    {
                        values.SwapValues(i, i +1);
                        swapped = true;
                    }
                }

            } while (swapped);
        }
    }
}