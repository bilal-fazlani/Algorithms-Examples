using Algorithms._2.Sorting;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Tests._2.Sorting
{
    public class InsertionSortTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public InsertionSortTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void CanSortUsingWhileLoop()
        {
            int[] values = {3, 1, 7, 10, 11, 5, 0, 4, 1, 9};
            _testOutputHelper.WriteLine("before: " + values.ToCommaSeparatedString());
            new InsertionSort().SortUsingWhileLoop(values);
            _testOutputHelper.WriteLine("after: " + values.ToCommaSeparatedString());
            values.Should().BeInAscendingOrder();
        }

        [Fact]
        public void CanSortUsingForLoop()
        {
            int[] values = {3, 1, 7, 10, 11, 5, 0, 4, 1, 9};
            _testOutputHelper.WriteLine("before: " + values.ToCommaSeparatedString());
            new InsertionSort().SortUsingForLoop(values);
            _testOutputHelper.WriteLine("after: " + values.ToCommaSeparatedString());
            values.Should().BeInAscendingOrder();
        }
    }
}