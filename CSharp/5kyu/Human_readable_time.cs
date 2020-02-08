public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        return string.Format("{0:d2}:{1:d2}:{2:d2}", seconds / 3600, seconds / 60 % 60, seconds % 60);
    }
}
