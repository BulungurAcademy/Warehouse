namespace WHDomain.Extensions;

public static class DateTimeExtensions
{
    /// <summary>
    /// Gets the value of the End of the day (23:59)
    /// </summary>
    /// <param name="target"></param>
    /// <returns></returns>
    public static DateTime ToDayEnd(this DateTime target)
    {
        return target.Date.AddDays(1).AddMilliseconds(-1);
    }

    /// <summary>
    /// Returns all the days of a month.
    /// </summary>
    /// <param name="year">The year.</param>
    /// <param name="month">The month.</param>
    /// <returns></returns>
    public static IEnumerable<DateTime> DaysOfMonth(int year, int month)
    {
        return Enumerable.Range(0, DateTime.DaysInMonth(year, month))
            .Select(day => new DateTime(year, month, day + 1));
    }

    /// <summary>
    /// Gets the total days in a month
    /// </summary>
    /// <param name="dateTime">The date time.</param>
    /// <returns></returns>
    public static int TotalDaysInMonth(this DateTime dateTime)
    {
        return DaysOfMonth(dateTime.Year, dateTime.Month).Count();
    }
}
