using Algorithms._3.Searching;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Tests._3.Searching
{
    public abstract class AbstractSearchingTest<T> where T: ISearchingAlgorithm, new()
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly ISearchingAlgorithm _searchingAlgorithm;

        protected AbstractSearchingTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _searchingAlgorithm = new T();
        }
        
        [Theory]
        [InlineData(200, 9)]
        [InlineData(0, 0)]
        [InlineData(8, 4)]
        [InlineData(400, -1)]
        [InlineData(105, -1)]
        [InlineData(-5, -1)]
        public void CanSearchAnArray(int search, int expectedIndex)
        {
            int[] values = {0, 2, 5, 6, 8, 12, 45, 102, 104, 200, 201};
            
            _testOutputHelper.WriteLine("array: " + values.ToCommaSeparatedString());
            _testOutputHelper.WriteLine("search : " + search);
            
            int searchedIndex = _searchingAlgorithm.Search(values, search);
            
            _testOutputHelper.WriteLine("searched Index : " + searchedIndex);
            
            searchedIndex.Should().Be(expectedIndex);
        }
    }
}