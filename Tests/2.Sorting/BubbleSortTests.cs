using Algorithms._2.Sorting;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Tests._2.Sorting
{
    public class BubbleSortTests : AbstractSortingTest<BubbleSort>
    {
        public BubbleSortTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
        }
    }
}