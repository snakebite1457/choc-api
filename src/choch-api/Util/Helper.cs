using System;

namespace choch_api.Util
{
    public class Helper
    {
        public static long ToUnixEpochDate(DateTime date)
            =>
                (long)
                    Math.Round(
                        (date.ToUniversalTime() - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero)).TotalSeconds);
    }
}