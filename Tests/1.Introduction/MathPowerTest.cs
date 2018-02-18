using FluentAssertions;
using Xunit;
using Math = Algorithms._1.Introduction.Math;

namespace Tests._1.Introduction
{
    public class MathPowerTest
    {
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 3, 8)]
        [InlineData(2, 0, 1)]
        [InlineData(0, 0, 1)]
        [InlineData(0, 1, 0)]
        [InlineData(1, 0, 1)]
        public void TestV2(int baseNumber, int exponent, int expectedResult)
        {
            Math math = new Math();
            math.PowerV2(baseNumber, exponent).Should().Be( expectedResult);
        }
        
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 3, 8)]
        [InlineData(2, 0, 1)]
        [InlineData(0, 0, 1)]
        [InlineData(0, 1, 0)]
        [InlineData(1, 0, 1)]
        public void TestV1(int baseNumber, int exponent, int expectedResult)
        {
            Math math = new Math();
            math.PowerV1(baseNumber, exponent).Should().Be( expectedResult);
        }
    }
}