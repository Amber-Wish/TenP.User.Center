using System.Collections.Generic;

namespace User.Center.Infrastructure.Extension.Extensions
{
    public static class StringExtension
    {
        public static string JoinAsString(this IEnumerable<string> source, string separator)
        {
            return string.Join(separator, source);
        }

        public static string JoinAsString<T>(this IEnumerable<T> source, string separator)
        {
            return string.Join(separator, source);
        }

    }
}