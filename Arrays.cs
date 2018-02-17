using System;

namespace Arrays
{
    public class Arrays
    {
        /// <summary>
        /// a method that will return the sum of all the elements of the integer array given array and its size as an argument.
        /// </summary>
        public void Sum()
        {
            int[] values = { 3, 5, 2, 6, 4, 2, 65, 4, 3, 3, 2, 5 };
            int size = values.Length;
            Console.WriteLine($"sum of all values : {GetSum(values,size)}");
        }
        
        static int GetSum(int[] values, int size)
        {
            int sum = 0;
            for (int i = 0; i < size; i++){
                sum += values[i];
            }

            return sum;
        }
    }
}