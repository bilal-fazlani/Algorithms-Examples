
namespace Algorithms._2.Sorting
{
    public class SelectionSort : ISortingAlgorithm
    {
        public void SortAscending(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = i+1; j < values.Length; j++)
                {
                    if (values[i] > values[j])
                    {
                        values.SwapValues(i, j);
                    }
                }
            }
        }

        public void SortDescending(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = i + 1; j < values.Length; j++)
                {
                    if (values[i] < values[j])
                    {
                        values.SwapValues(i, j);
                    }
                }
            }
        }
    }
}