namespace LittOmLinqOgExceptions
{
    internal static class StringExtensions
    {
        public static bool StartsAndEndsWith(this string value, string prefix)
        {
            return value.StartsWith(prefix) && value.EndsWith(prefix);
        }
    }
}
