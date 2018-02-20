namespace Algorithms._3.Searching
{
    public class BinarySearchLoop : ISearchingAlgorithm
    {
        public int Search(int[] values, int search)
        {
            int left = 0, right = values.Length-1;

            do
            {
                int middle = (left + right) / 2;

                if (values[middle] == search)
                {
                    return middle;
                }

                if (values[middle] > search)
                {
                    right = middle -1;
                }
                
                if(values[middle] < search)
                {
                    left = middle + 1;
                }
            } while (right >= left);

            return -1;
        }
    }
}