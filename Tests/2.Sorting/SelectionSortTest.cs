using Algorithms._2.Sorting;
using Xunit.Abstractions;

namespace Tests._2.Sorting
{
    public class SelectionSortTest : AbstractSortingTest<SelectionSort>
    {
        public SelectionSortTest(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
        }
    }
}