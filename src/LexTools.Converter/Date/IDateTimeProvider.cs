using System;

namespace LexTools.Converter.Date
{
    public interface IDateTimeProvider
    {
        string Get12HString(DateTime value);

        DateTime GetNowPst();

        DateTime SpecifyToPst(DateTime value);

        DateTime BeginOfMonthPst(DateTime value);

        DateTime ConvertUtcTimeToLocal(DateTime utcDate, string timeZoneId);
    }
}