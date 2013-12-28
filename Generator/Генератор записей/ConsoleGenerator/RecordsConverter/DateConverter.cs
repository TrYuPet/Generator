using System;
using System.Text.RegularExpressions;

namespace Converters
{
    public class DateConverter
    {
        public static string DateToString(DateTime dateTime)
        {
            return String.Format(@"{0}/{1}/{2} {3}:{4}:{5}:{6}", dateTime.Year, dateTime.Month, dateTime.Day,
                dateTime.Hour, dateTime.Minute, dateTime.Second, dateTime.Millisecond);
        }

        public static DateTime StringToDate(string stringDate)
        {
            const string pattern = @"(?<Year>\d{4})/(?<Month>\d+)/(?<Day>\d+)T(?<Hour>\d+):(?<Minute>\d+):(?<Second>\d+):(?<Millisecond>\d+)";
            var matches = Regex.Match(stringDate, pattern);
            var dateTime = new DateTime();
            if (matches != Match.Empty)
            {
                dateTime = new DateTime(Convert.ToInt32(matches.Groups["Year"].Value), Convert.ToInt32(matches.Groups["Month"].Value), Convert.ToInt32(matches.Groups["Day"].Value),
                    Convert.ToInt32(matches.Groups["Hour"].Value), Convert.ToInt32(matches.Groups["Minute"].Value), Convert.ToInt32(matches.Groups["Second"].Value),
                    Convert.ToInt32(matches.Groups["Millisecond"].Value));
            }
            return dateTime;
        }
    }
}
