using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CDate.Enums;

namespace CDate.Core
{
    /// <summary>
    /// 
    /// </summary>
    public class CDate
    {
        private CDate cDate;
        private Millisecond millisecond;
        private Second second;
        private Minute minute;
        private Hour hour;
        private Day day;
        private Week week;
        private Month month;
        private Year year;
        private int dayOfMonth;
        private DateTime nativeDate;
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
            this.Millisecond = new Millisecond(pmilliseconds);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pyear"></param>
        /// <param name="pmonth"></param>
        /// <param name="pdayOfMonth"></param>
        /// <param name="phours"></param>
        /// <param name="pminutes"></param>
        /// <param name="pseconds"></param>
        /// <param name="pmilliseconds"></param>
        public CDate(int pyear, Months pmonth, int pweek, int pdayOfMonth, int phours, int pminutes, int pseconds, long pmilliseconds)
        {
            this.Year = new Year(pyear);
            this.Month = new Month(pmonth);
            this.Week = new Week(pweek);
            this.DayOfMonth = pdayOfMonth;
            this.Day = new Day(pdayOfMonth);
            this.Hour= new Hour(phours);
            this.Minute = new Minute(pminutes);
            this.Second = new Second(pseconds);
            this.Millisecond = new Millisecond(pmilliseconds);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pyear"></param>
        /// <param name="pmonth"></param>
        /// <param name="pnameDay"></param>
        /// <param name="phours"></param>
        /// <param name="pminutes"></param>
        /// <param name="pseconds"></param>
        /// <param name="pmilliseconds"></param>
        private CDate(int pyear, Months pmonth, Days pnameDay, int phours, int pminutes, int pseconds, long pmilliseconds)
        {
            this.Year = new Year(pyear);
            this.Month = new Month(pmonth);
            this.Day = new Day(pnameDay);
            this.Hour = new Hour(phours);
            this.Minute = new Minute(pminutes);
            this.Second = new Second(pseconds);
            this.Millisecond = new Millisecond(pmilliseconds);
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
        public Year Year
        {
            get { return year; }
            set { year = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Month Month
        {
            get { return month; }
            set { month = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Day Day
        {
            get { return day; }
            set { day = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Hour Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Minute Minute
        {
            get { return minute; }
            set { minute = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Second Second
        {
            get { return second; }
            set { second = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Millisecond Millisecond
        {
            get { return millisecond; }
            set { millisecond = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public String DateString
        {
            get { return dateString; }
            set { dateString = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public int DayOfMonth
        {
            get { return dayOfMonth; }
            set { dayOfMonth = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public Week Week
        {
            get { return week; }
            set { week = value; }
        }

        /// <summary>
        /// Return the full year
        /// </summary>
        /// <returns>Year 4 digits (Ex: 2014)</returns>
        public int getFullYear()
        {
            return this.Year.getFullYear(this.Month.getMonth(), this.DayOfMonth);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int getWeek()
        {
            return this.Week.getWeek(this.getFullYear(), this.Month.getMonth(), this.DayOfMonth);
        }

    }
}