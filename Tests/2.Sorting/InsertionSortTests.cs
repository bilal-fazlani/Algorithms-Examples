using Algorithms._2.Sorting;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Tests._2.Sorting
{
    public class InsertionSortTests : AbstractSortingTest<InsertionSort>
    {
        public InsertionSortTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
        }
    }
}