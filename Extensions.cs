namespace Algorithms
{
    public static class Extensions
    {
        public static void SwapValues(this int[]values, int position1, int position2)
        {
            int valueAtPosition1 = values[position1];
            values[position1] = values[position2];
            values[position2] = valueAtPosition1;
        }
    }
}