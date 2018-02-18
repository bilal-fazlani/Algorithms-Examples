namespace Algorithms._1.Introduction
{
    public class Math
    {
        public int PowerV1(int baseNumber, int exponent)
        {
            /*
             * PSEUDOCODE
             *
             * SET result = 1
             * WHILE i < exponent
             *     result = result * base
             *     exponent--
             */

            int result = 1;
            while (exponent > 0)
            {
                result = result * baseNumber;
                exponent--;
            }

            return result;
        }

        public int PowerV2(int baseNumber, int exponent)
        {
            /*
             * SET result = 1
             * FOR i : 0 -> exponent
             *     SET result = result * baseNumber
             *     i++
             */

            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result = result * baseNumber;
            }

            return result;
        }
    }
}