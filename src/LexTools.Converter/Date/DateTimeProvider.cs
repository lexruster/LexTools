using System;

namespace LexTools.Converter.Date
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime SpecifyToPst(DateTime value)
        {
            return DateTime.SpecifyKind(value, DateTimeKind.Local);
        }

        public DateTime GetNowPst()
        {
            return SpecifyToPst(DateTime.Now);
        }

        public string Get12HString(DateTime value)
        {
            return value.ToString("dd/MM/yyyy hh:mm");
        }

        public DateTime BeginOfMonthPst(DateTime value)
        {
            return SpecifyToPst(BeginOfMonth(value));
        }

        private static DateTime BeginOfMonth(DateTime value)
        {
            return new DateTime(value.Year, value.Month, 1);
        }

        public DateTime ConvertUtcTimeToLocal(DateTime utcDate, string timeZoneId)
        {
            var easternZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            DateTime easternTime = TimeZoneInfo.ConvertTimeFromUtc(utcDate, easternZone);
            return easternTime;
        }
    }
}
