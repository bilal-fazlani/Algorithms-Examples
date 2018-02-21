
namespace Algorithms._2.Sorting
{
    public class SelectionSort : ISortingAlgorithm
    {
        public void SortAscending(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values.SwapValues(i, FindIndexOfMin(values, i, values.Length-1));
            }
        }

        private int FindIndexOfMin(int[] values, int start, int end)
        {
            int min = values[start];
            int minIndex = start;
            
            for (int i = start; i <= end; i++)
            {
                if (values[i] < min)
                {
                    min = values[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        public void SortDescending(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values.SwapValues(i, FindIndexOfMax(values, i, values.Length-1));
            }
        }

        private int FindIndexOfMax(int[] values, int start, int end)
        {
            var maxLocation = start;
            var maxValue = values[start];
            
            for (int i = start; i <= end; i++)
            {
                if (values[i] > maxValue)
                {
                    maxLocation = i;
                    maxValue = values[i];
                }
            }

            return maxLocation;
        }
    }
}