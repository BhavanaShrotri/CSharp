using System;

namespace DateUtils
{
    public class DateFormatter
    {
        public string Format(DateTime date, string prefix = "default ")
        {
            return prefix + date.ToShortDateString();
        }
    }
}
