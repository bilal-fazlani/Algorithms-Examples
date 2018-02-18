using System.Collections;

namespace Tests
{
    public static class Extensions
    {
        public static string ToCommaSeparatedString(this IEnumerable enumerable)
        {
            return string.Join(", ", enumerable);
        }
    }
}