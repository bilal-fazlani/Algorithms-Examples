
namespace Algorithms._1.Introduction
{
    public class Arrays
    {
        /// <summary>
        /// a method that will return the sum of all the elements of the integer array given array and its size as an argument.
        /// </summary>
        /// <param name="values"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public int Sum(int[] values, int size)
        {
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += values[i];
            }

            return sum;
        }

        /// <summary>
        /// Searches given value in the given array
        /// </summary>
        /// <param name="values"></param>
        /// <param name="itemToSearch"></param>
        /// <returns>Index of searched item</returns>
        public int Search(string[] values, string itemToSearch)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == itemToSearch)
                    return i;
            }

            return -1;
        }
    }
}