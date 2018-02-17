using System;

namespace Algorithms
{
    public class Arrays
    {
        /// <summary>
        /// a method that will return the sum of all the elements of the integer array given array and its size as an argument.
        /// SUM
        /// </summary>
        public void Sum()
        {
            int[] values = {3, 5, 2, 6, 4, 2, 65, 4, 3, 3, 2, 5};
            int size = values.Length;
            Console.WriteLine($"sum of all values : {GetSum(values, size)}");
        }

        static int GetSum(int[] values, int size)
        {
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += values[i];
            }

            return sum;
        }

        /// <summary>
        /// Write a method, which will search an array for some given value.
        /// SEQUENTIAL SEARCH
        /// </summary>
        public void Search()
        {
            string[] values = {"bilal", "fazlani", "mumbai"};
            string search = "mumbai";

            int indexOfItem = SearchItemInArray(values, search);
            Console.WriteLine($"item: '{search}' found on index '{indexOfItem}'");
        }

        private static int SearchItemInArray(string[] values, string itemToSearch)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == itemToSearch)
                    return i;
            }

            throw new Exception("value not found in array");
        }
    }
}