using System;

namespace LexTools.Converter.Date
{
    public class UnixTimeHelper
    {
        public static DateTime FromUnixTime(decimal unixTimeSeconds)
        {
            return OffsetFromUnixTime(unixTimeSeconds).DateTime;
        }

        public static DateTime FromUnixTime(long unixTimeSeconds)
        {
            return OffsetFromUnixTime(unixTimeSeconds).DateTime;
        }

        public static DateTimeOffset OffsetFromUnixTime(long unixTimeSeconds)
        {
            return DateTimeOffset.FromUnixTimeSeconds(unixTimeSeconds);
        }

        public static DateTimeOffset OffsetFromUnixTime(decimal unixTimeSeconds)
        {
            long unixTimeMilliseconds = Convert.ToInt64(unixTimeSeconds * 1000);

            return DateTimeOffset.FromUnixTimeMilliseconds(unixTimeMilliseconds);
        }
    }
}