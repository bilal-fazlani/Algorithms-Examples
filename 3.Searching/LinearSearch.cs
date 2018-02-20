namespace Algorithms._3.Searching
{
    public class LinearSearch : ISearchingAlgorithm
    {
        public int Search(int[] values, int search)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == search)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}