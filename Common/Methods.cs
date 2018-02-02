using System;
using System.Globalization;

namespace Common
{
    public class Methods
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="today">DateTime.Today</param>
        /// <returns>
        /// Matching string for the month matched
        /// </returns>
        private static string GetMonthValue(DateTime today)
        {
            return string.Format("{0}", Constants.months[today.Month - 1]);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="today">DateTime.Today</param>
        /// <returns>
        /// Matching string for the Weekday matched
        /// </returns>
        private static string GetWeekdayValue(DateTime today)
        {
            return string.Format("{0}", Constants.weekdays[(int) (CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(today) - 1)]);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="today">DateTime.Today</param>
        /// <returns>
        /// Matching string for the day matched
        /// </returns>
        private static string GetDayValue(DateTime today)
        {
            return string.Format("{0}", Constants.days[today.Day - 1]);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="today">DateTime.Today</param>
        /// <returns>
        /// Completed Password
        /// </returns>
        public static string AssemblePassword(DateTime today)
        {
            return string.Format("{0}{1}{2}{3}", Constants.prefix, GetMonthValue(today), GetWeekdayValue(today), GetDayValue(today));
        }
    }
}
