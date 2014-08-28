using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDate
{
    public static  class CDateValidator
    {
        private static readonly int daysInMonth = 31;
        private static readonly int monthInYear = 12;
        private static readonly String separatorHyphen = "-";
        private static readonly String separatorSlash = "/";
        private static String[] separators = new String[2];

        public static bool isValidateDate(String date)
        {
            bool isValidDate = false;
            String dateInternal = date.TrimStart().TrimEnd();

            if (dateInternal.Contains(separatorHyphen) || dateInternal.Contains(separatorSlash))
            {
                separators[0] = separatorHyphen;
                separators[1] = separatorSlash;
                String[] dateParts = dateInternal.Split(separators, StringSplitOptions.None);

                if (dateParts.Length == 3)
                {
                	if ((dateParts[2].Split(' ')).Length == 1)
                    {
                        //0. Day, 1. Month, 2. Year
                        if (isValidateDay(dateParts[0]) && isValidateMonth(dateParts[1]))
                        {
                            isValidDate = true;
                        }
                    }
                    else
                    {
                        throw new FormatException("Date is invalid");
                    }
                }
                else
                {
                    throw new FormatException("Date is invalid");
                }
            }
            else
            {
                throw new FormatException("Date is invalid");
            }

            return isValidDate;
        }

        /// <summary>
        /// Validate if the day is correct
        /// </summary>
        /// <param name="day">Day number</param>
        /// <returns>True is correct, otherwise, false</returns>
        private static bool isValidateDay(String day)
        {
            return Convert.ToInt32(day) <= daysInMonth;
        }

        /// <summary>
        /// Validate if the month is correct
        /// </summary>
        /// <param name="month">Month number</param>
        /// <returns>True is correct, otherwise, false</returns>
        private static bool isValidateMonth(String month)
        {
            return Convert.ToInt32(month) <= monthInYear;
        }
    }
}