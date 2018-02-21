namespace Algorithms._1.Introduction
{
    public class PowerCalculator
    {
        public int Calculate(int baseNumber, int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result = result * baseNumber;
            }

            return result;
        }
    }
}