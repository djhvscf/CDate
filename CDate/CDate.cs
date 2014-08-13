using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDate.Core
{
    /// <summary>
    /// 
    /// </summary>
    public class CDate
    {
        private CDate cDate;
        private DateTime nativeDate;
        private int year;
        private int month;
        private int date;
        private int hours;
        private int minutes;
        private int seconds;
        private long milliseconds;
        private String dateString;
        private static readonly int monthInYear = 12;
        private static readonly int daysInMonth = 31;
        private static readonly int hoursInDay = 24;
        private static readonly int minutesInHour = 60;
        private static readonly int secondsInMinute = 60;
        private static readonly int millisecondsInSecond = 1000;
        private static readonly String ISO_FORMAT_STRING = "yyyy-MM-dd'T'HH:mm:ss(.fff)";
        private static readonly String ISO_FORMAT_STRING_TZ = (ISO_FORMAT_STRING + "zzz");

        /// <summary>
        /// 
        /// </summary>
        public CDate(){}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pcDate"></param>
        public CDate(CDate pcDate)
        {
            this.CDate = pcDate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pnativeDate"></param>
        public CDate(DateTime pnativeDate)
        {
            this.NativeDate = pnativeDate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pmilliseconds"></param>
        public CDate(long pmilliseconds)
        {
            this.Milliseconds = pmilliseconds;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pyear"></param>
        /// <param name="pmonth"></param>
        /// <param name="pdate"></param>
        /// <param name="phours"></param>
        /// <param name="pminutes"></param>
        /// <param name="pseconds"></param>
        /// <param name="pmilliseconds"></param>
        public CDate(int pyear, int pmonth, int pdate, int phours, int pminutes, int pseconds, long pmilliseconds)
        {
            this.Year = pyear;
            this.Month = pmonth;
            this.Date = pdate;
            this.Hours = phours;
            this.Minutes = pminutes;
            this.Seconds = pseconds;
            this.Milliseconds = pmilliseconds;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pdateString"></param>
        public CDate(String pdateString)
        {
            this.DateString = pdateString;
        }

        /// <summary>
        /// 
        /// </summary>
        public CDate CDate
        {
            get { return cDate; }
            set { cDate = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime NativeDate
        {
            get { return nativeDate; }
            set { nativeDate = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Date
        {
            get { return date; }
            set { date = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public long Milliseconds
        {
            get { return milliseconds; }
            set { milliseconds = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public String DateString
        {
            get { return dateString; }
            set { dateString = value; }
        }
    }
}