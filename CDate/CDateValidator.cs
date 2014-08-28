using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CDate
{
    public static class CDateValidator
    {
        private static readonly String separatorHyphen = "-";
        private static readonly String separatorSlash = "/";
        private static String[] separators = new String[2];

        private static bool validateDate(String date)
        {
            bool isValidDate = false;
            String dateInternal = date.TrimStart().TrimEnd();
            if (dateInternal.Contains(separatorHyphen) || dateInternal.Contains(separatorSlash))
            {
                int[] dateParts = getDateParts(date);

                //0. Day, 1. Month, 2. Year
                isValidDate = isDateValid(dateParts[2], dateParts[1], dateParts[0]);
            }
            else
            {
                throw new FormatException("Date is invalid");
            }

            return isValidDate;
        }

        /// <summary>
        /// Function that valid if the date time is correct
        /// </summary>
        /// <param name="year">Year</param>
        /// <param name="month">Month</param>
        /// <param name="day">Day</param>
        /// <returns>True if the date is valid, otherwise, false</returns>
        private static bool isDateValid(int year, int month, int day)
        {
            if (year < DateTime.MinValue.Year || year > DateTime.MaxValue.Year)
            {
                return false;
            }

            if (month < 1 || month > 12)
            {
                return false;
            }

            return day > 0 && day <= DateTime.DaysInMonth(year, month);
        }

        /// <summary>
        /// Function that valid if the date time is correct
        /// </summary>
        /// <param name="year">Year</param>
        /// <param name="month">Month</param>
        /// <param name="day">Day</param>
        /// <param name="calendar">Calendar to check the date</param>
        /// <returns>True if the date is valid, otherwise, false</returns>
        private static bool isDateValid(int year, int month, int day, Calendar calendar)
        {
            if (year < calendar.MinSupportedDateTime.Year || year > calendar.MaxSupportedDateTime.Year)
            {
                return false;
            }

            if (month < 1 || month > calendar.GetMonthsInYear(year))
            {
                return false;
            }

            return day > 0 && day <= DateTime.DaysInMonth(year, month);
        }

        /// <summary>
        /// Convert to correct date time
        /// </summary>
        /// <param name="firstPos">First position of the date</param>
        /// <param name="secondPos">Second position of the date</param>
        /// <param name="thirdPos">Third position of the date</param>
        /// <returns>New date format</returns>
        private static String convertDate(int firstPos, int secondPos, int thirdPos)
        {
            String newDate = "";
            if (firstPos > 12)
            {
                newDate = secondPos.ToString() + separatorSlash + firstPos.ToString() + separatorSlash + thirdPos.ToString();
            }

            return newDate;
        }

        private static DateTime? tryNewDate(int year, int month, int day, Calendar calendar)
        {
            if (calendar == null)
            {
                calendar = new GregorianCalendar();
            }

            if (!isDateValid(year, month, day, calendar))
            {
                return null;
            }

            try
            {
                return new DateTime(year, month, day, calendar);
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }
        }

        public static DateTime? tryNewDate(String date, Calendar calendar)
        {
            int[] dateParts = getDateParts(date);

            try
            {
                convertDate(dateParts[0], dateParts[1], dateParts[2]);
                return tryNewDate(dateParts[0], dateParts[1], dateParts[2], calendar);
            }
            catch
            {
                return Convert.ToDateTime(convertDate(Convert.ToInt32(dateParts[0]), Convert.ToInt32(dateParts[1]), Convert.ToInt32(dateParts[2])));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private static int[] getDateParts(String date)
        {
            try
            {
                int[] arrayToReturn;
                String[] dateParts;
                arrayToReturn = new int[3];

                separators[0] = separatorHyphen;
                separators[1] = separatorSlash;

                dateParts = date.Split(separators, 3, StringSplitOptions.None);
                for (int i = 0; i < dateParts.Length; i++)
                {
                    arrayToReturn[i] = Convert.ToInt32(dateParts[i]);
                }

                return arrayToReturn;
            }
            catch
            {
                throw new FormatException("Date is invalid");
            }
        }
    }
}