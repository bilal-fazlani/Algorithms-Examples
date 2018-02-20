using Algorithms._2.Sorting;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Tests._2.Sorting
{
    public class InsertionSortTests
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly InserttionSort _inserttionSort;

        public InsertionSortTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _inserttionSort = new InserttionSort();
        }

        [Fact]
        public void CanSortAscending()
        {
            int[] values = {3, 1, 7, 10, 11, 5, 0, 4, 1, 9};
            _testOutputHelper.WriteLine("before: " + values.ToCommaSeparatedString());
            _inserttionSort.SortAscending(values);
            _testOutputHelper.WriteLine("after: " + values.ToCommaSeparatedString());
            values.Should().BeInAscendingOrder();
        }
        
        [Fact]
        public void CanSortDescending()
        {
            int[] values = {3, 1, 7, 10, 11, 5, 0, 4, 1, 9};
            _testOutputHelper.WriteLine("before: " + values.ToCommaSeparatedString());
            _inserttionSort.SortDescending(values);
            _testOutputHelper.WriteLine("after: " + values.ToCommaSeparatedString());
            values.Should().BeInDescendingOrder();
        }
    }
}