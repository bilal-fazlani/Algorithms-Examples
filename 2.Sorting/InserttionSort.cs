namespace Algorithms._2.Sorting
{
    public class InserttionSort
    {
        public void SortAscending(int[] values)
        {
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] < values[i - 1])
                {
                    int j = i;
                    int newValue = values[j];
                    while (j > 0 && newValue < values[j-1])
                    {
                        values[j] = values[j - 1];
                        j--;
                    }

                    values[j] = newValue;
                }
            }
        }

        public void SortDescending(int[] values)
        {
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > values[i - 1])
                {
                    int j = i;
                    int pushValue = values[j];
                    while (j > 0 && pushValue > values[j-1])
                    {
                        values[j] = values[j - 1];
                        j--;
                    }

                    values[j] = pushValue;
                }
            }
        }
    }
}