using Algorithms._3.Searching;
using Xunit.Abstractions;

namespace Tests._3.Searching
{
    public class LinearSearchTest : AbstractSearchingTest<LinearSearch>
    {
        public LinearSearchTest(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
        }
    }
}