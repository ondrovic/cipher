using System;

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
        private static string GetMonthValue(DateTime today) => Constants.Months[today.Month - 1];

        /// <summary>
        /// 
        /// </summary>
        /// <param name="today">DateTime.Today</param>
        /// <returns>
        /// Matching string for the Weekday matched
        /// </returns>
        private static string GetWeekdayValue(DateTime today) => Constants.Weekdays[(int)today.DayOfWeek];

        /// <summary>
        /// 
        /// </summary>
        /// <param name="today">DateTime.Today</param>
        /// <returns>
        /// Matching string for the day matched
        /// </returns>
        private static string GetDayValue(DateTime today) => Constants.Days[today.Day - 1];
        /// <summary>
        /// 
        /// </summary>
        /// <param name="today">DateTime.Today</param>
        /// <returns>
        /// Completed Password
        /// </returns>
        public static string AssemblePassword(DateTime today)
        {
            return $"{Constants.Prefix}{GetMonthValue(today)}{GetWeekdayValue(today)}{GetDayValue(today)}";
        }
    }
}
