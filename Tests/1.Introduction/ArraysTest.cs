using Algorithms._1.Introduction;
using FluentAssertions;
using Xunit;

namespace Tests._1.Introduction
{
    public class ArraysTest
    {
        Arrays _arrays = new Arrays();
        
        [Fact]
        public void TestSum()
        {
            int[] values = {3, 5, 2, 6, 4, 2, 6, 4, 3, 3, 2, 5};
            int size = values.Length;

            _arrays.Sum(values, size).Should().Be(45);
        }

        [Fact]
        public void TestSearch()
        {
            string[] values = {"bilal", "fazlani", "mumbai"};
            string search = "mumbai";
            
            _arrays.Search(values, search).Should().Be(2);
        }
    }
}