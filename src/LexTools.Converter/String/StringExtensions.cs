namespace LexTools.Converter.String
{
    public static class StringExtensions
    {
        public static string SafeSubstring(this string input, int startIndex, int length)
        {
            if (input.Length >= startIndex + length)
            {
                return input.Substring(startIndex, length);
            }

            if (input.Length > startIndex)
            {
                return input.Substring(startIndex);
            }

            return string.Empty;
        }
    }
}