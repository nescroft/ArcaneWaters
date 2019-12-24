using System;

public static class Util
{
    public static string ConvertToLocalTime(DateTime? dateTime)
    {
        return TimeZoneInfo.ConvertTimeFromUtc((DateTime)dateTime, TimeZoneInfo.Local).ToString("MM/dd/yyyy hh:mm tt");
    }
}
