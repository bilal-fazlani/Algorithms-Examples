using Algorithms._2.Sorting;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Tests._2.Sorting
{
    public class BubbleSortTests
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly BubbleSort _bubbleSort;

        public BubbleSortTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _bubbleSort = new BubbleSort();
        }

        [Fact]
        public void CanSortAscending()
        {
            int[] values = {3, 1, 7, 10, 11, 5, 0, 4, 1, 9};
            _testOutputHelper.WriteLine("before: " + values.ToCommaSeparatedString());
            _bubbleSort.SortAscending(values);
            _testOutputHelper.WriteLine("after: " + values.ToCommaSeparatedString());
            values.Should().BeInAscendingOrder();
        }

        [Fact]
        public void CanSortDescending()
        {
            int[] values = {3, 1, 7, 10, 11, 5, 0, 4, 1, 9};
            _testOutputHelper.WriteLine("before: " + values.ToCommaSeparatedString());
            _bubbleSort.SortDescending(values);
            _testOutputHelper.WriteLine("after: " + values.ToCommaSeparatedString());
            values.Should().BeInDescendingOrder();
        }
    }
}