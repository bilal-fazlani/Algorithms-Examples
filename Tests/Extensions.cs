using System.Collections.Generic;

namespace Tests
{
    public static class Extensions
    {
        public static string ToCommaSeparatedString(this IEnumerable<int> enumerable)
        {
            return string.Join(", ", enumerable);
        }
    }
}