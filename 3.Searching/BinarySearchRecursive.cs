
namespace Algorithms._3.Searching
{
    public class BinarySearchRecursive : ISearchingAlgorithm
    {
        public int Search(int[] values, int search)
        {
            int left = 0;
            int right = values.Length-1;

            return Search(values, left, right, search);
        }

        private int Search(int[] values, int left, int right, int search)
        {
            if (right >= left)
            {
                int middle = (left + right) / 2;
    
                if (values[middle] == search)
                {
                    return middle;
                }
            
                if (values[middle] < search)
                {
                    return Search(values, middle + 1, right, search);
                }
            
                if(values[middle] > search)
                {
                    return Search(values, left, middle - 1 , search);
                }
            }

            return -1;
        }
    }
}