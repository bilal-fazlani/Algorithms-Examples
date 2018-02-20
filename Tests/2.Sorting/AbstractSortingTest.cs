using Algorithms._2.Sorting;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Tests._2.Sorting
{
    public abstract class AbstractSortingTest<T> where T: ISortingAlgorithm, new()
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly T _sort;

        protected AbstractSortingTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _sort = new T();
        }

        [Fact]
        public void CanSortAscending()
        {
            int[] values = {3, 1, 7, 10, 11, 5, 0, 4, 1, 9};
            _testOutputHelper.WriteLine("before: " + values.ToCommaSeparatedString());
            _sort.SortAscending(values);
            _testOutputHelper.WriteLine("after: " + values.ToCommaSeparatedString());
            values.Should().BeInAscendingOrder();
        }

        [Fact]
        public void CanSortDescending()
        {
            int[] values = {3, 1, 7, 10, 11, 5, 0, 4, 1, 9};
            _testOutputHelper.WriteLine("before: " + values.ToCommaSeparatedString());
            _sort.SortDescending(values);
            _testOutputHelper.WriteLine("after: " + values.ToCommaSeparatedString());
            values.Should().BeInDescendingOrder();
        }
    }
}