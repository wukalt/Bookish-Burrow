using System.Globalization;

namespace KalaDuck.Utility.Convertor;

public static class DatetimeConvertor
{
    public static string ToShamsi(this DateTime dateTime)
    {
        PersianCalendar persianCalendar = new PersianCalendar();
        int year = persianCalendar.GetYear(dateTime);
        int month = persianCalendar.GetMonth(dateTime);
        int day = persianCalendar.GetDayOfMonth(dateTime);

        return $"{year}/{month:00}/{day:00}";
    }
}
