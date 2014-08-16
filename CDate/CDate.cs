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
        private Year year;
        private Month month;
        private Day day;
        private Week week;
        private Hour hour;
        private Minute minute;
        private Second second;
        private Millisecond millisecond;
        private DateTime nativeDate;
        private static readonly String formatMMddyy = "MM/dd/yy";
        private static readonly String formatddMMyy = "dd/MM/yy";
        private static readonly String formatMMddyyyy = "MM/dd/yyyy";
        private static readonly String formatddMMyyyy = "dd/MM/yyyy";
        private static readonly String format24Hour = "HH:mm:ss";
        private static readonly String format12Hour = "hh:mm:ss";
        private static readonly String formatAMPM = "tt";
        //private int dayOfMonth;
        //private String dateString;
        /*private static readonly int monthInYear = 12;
        private static readonly int daysInMonth = 31;
        private static readonly int hoursInDay = 24;
        private static readonly int minutesInHour = 60;
        private static readonly int secondsInMinute = 60;
        private static readonly int millisecondsInSecond = 1000;
        private static readonly String ISO_FORMAT_STRING = "yyyy-MM-dd'T'HH:mm:ss(.fff)";
        private static readonly String ISO_FORMAT_STRING_TZ = (ISO_FORMAT_STRING + "zzz");*/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pnativeDate"></param>
        public CDate(DateTime pnativeDate)
        {
            this.NativeDate = pnativeDate;
            this.Year = new Year(pnativeDate.Year);
            this.Month = new Month(pnativeDate.Month);
            this.Day = new Day(pnativeDate.Day);
            this.Week = new Week();
            this.Hour = new Hour(0);
            this.Minute = new Minute(pnativeDate.Minute);
            this.Second = new Second(pnativeDate.Second);
            this.Millisecond = new Millisecond(pnativeDate.Millisecond);
        }

        /// <summary>
        /// 
        /// </summary>
        private DateTime NativeDate
        {
            get { return nativeDate; }
            set { nativeDate = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private Year Year
        {
            get { return year; }
            set { year = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private Month Month
        {
            get { return month; }
            set { month = value; }
        }
        
        
        /// <summary>
        /// 
        /// </summary>
        private Week Week
        {
            get { return week; }
            set { week = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private Day Day
        {
            get { return day; }
            set { day = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private Hour Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private Minute Minute
        {
            get { return minute; }
            set { minute = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private Second Second
        {
            get { return second; }
            set { second = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private Millisecond Millisecond
        {
            get { return millisecond; }
            set { millisecond = value; }
        }

        /*/// <summary>
        /// 
        /// </summary>
        private String DateString
        {
            get { return dateString; }
            set { dateString = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        private int DayOfMonth
        {
            get { return dayOfMonth; }
            set { dayOfMonth = value; }
        }*/
	
    	public String getDate_MM_dd_yy()
        {
        	return this.NativeDate.ToString(formatMMddyy);
        }
        
        public String getDate_MM_dd_yyyy()
        {
        	return this.NativeDate.ToString(formatMMddyyyy);
        }
        
        public String getDate_MM_dd_yy_HH_mm_ss(bool isAMPM)
        {
    		return this.NativeDate.ToString(formatMMddyy + " " + format24Hour + (isAMPM ? " " + formatAMPM : ""));
        }
        
        public String getDate_MM_dd_yyyy_HH_mm_ss(bool isAMPM)
        {
    		return this.NativeDate.ToString(formatMMddyyyy + " " + format24Hour + (isAMPM ? " " + formatAMPM : ""));
        }
        
        public String getDate_MM_dd_yy_hh_mm_ss(bool isAMPM)
        {
        	return this.NativeDate.ToString(formatMMddyy + " " + format12Hour + (isAMPM ? " " + formatAMPM : ""));
        }
        
        public String getDate_MM_dd_yyyy_hh_mm_ss(bool isAMPM)
        {
        	return this.NativeDate.ToString(formatMMddyyyy + " " + format12Hour + (isAMPM ? " " + formatAMPM : ""));
        }
        
        public String getDate_dd_MM_yy()
        {
        	return this.NativeDate.ToString(formatddMMyy);
        }
        
        public String getDate_dd_MM_yyyy()
        {
        	return this.NativeDate.ToString(formatddMMyyyy);
        }
        
        public String getDate_dd_MM_yy_HH_mm_ss(bool isAMPM)
        {
        	return this.NativeDate.ToString(formatddMMyy + " " + format24Hour + (isAMPM ? " " + formatAMPM : ""));
        }
        
        public String getDate_dd_MM_yyyy_HH_mm_ss(bool isAMPM)
        {
        	return this.NativeDate.ToString(formatddMMyyyy + " " + format24Hour + (isAMPM ? " " + formatAMPM : ""));
        }
        
        public String getDate_dd_MM_yy_hh_mm_ss(bool isAMPM)
        {
        	return this.NativeDate.ToString(formatddMMyy + " " + format12Hour + (isAMPM ? " " + formatAMPM : ""));
        }
        
        public String getDate_dd_MM_yyyy_hh_mm_ss(bool isAMPM)
        {
        	return this.NativeDate.ToString(formatddMMyyyy + " " + format12Hour + (isAMPM ? " " + formatAMPM : ""));
        }
        
        public int getYear()
        {
        	return this.Year._NumberYear;
        }
        
        public int getMonthNumber()
        {
        	return this.Month._Month;
        }
        
        public String getMonthName()
        {
			return new System.Globalization.DateTimeFormatInfo().GetMonthName(this.Month._Month).ToString();
        }
        
        public int getDayNumber()
        {
        	return this.Day._NumberDay;
        }
        
        public String getDayName()
        {
			return this.NativeDate.DayOfWeek.ToString();
			//return this.NativeDate.ToString("dddd"); Spanish
        }
        
        public int getWeek()
        {
        	return this.Week.getWeek(this.NativeDate);
        }
        
        public String getHour(bool isFormat24Hour)
        {
			return this.NativeDate.ToString((isFormat24Hour ? format24Hour : format12Hour));
        }
        
        public int getMinute()
        {
        	return this.Minute._Minute;
        }
        
        public int getSecond()
        {
        	return this.Second._Second;
        }
        
        public int getMillisecond()
        {
        	return this.Millisecond._Millisecond;
        }
        
        #region Next Version
        /*
        public static long getTimeElapsedInNanoseconds(DateTime dateTime1, DateTime dateTime2)
        {
			return getElapsedTicks(dateTime1, dateTime2) * 100;
        }
        
        public static long getTimeElapsedInTicks(DateTime dateTime1, DateTime dateTime2)
        {
			return getElapsedTicks(dateTime1, dateTime2);
        }
        
        public static double getTimeElapseInMillisecond(DateTime dateTime1, DateTime dateTime2)
        {
			return createTimeSpan(dateTime1, dateTime2).TotalMilliseconds;
        }
        
        public static double getTimeElapsedInSecond(DateTime dateTime1, DateTime dateTime2)
        {
			return createTimeSpan(dateTime1, dateTime2).TotalSeconds;
        }
        
        public static double getTimeElapsedInMinutes(DateTime dateTime1, DateTime dateTime2)
        {
			return createTimeSpan(dateTime1, dateTime2).TotalMinutes;
        }
        
        public static double getTimeElapsedInHours(DateTime dateTime1, DateTime dateTime2)
        {
			return createTimeSpan(dateTime1, dateTime2).TotalHours;
        }
        
        public static double getTimeElapsedInDays(DateTime dateTime1, DateTime dateTime2)
        {
			return createTimeSpan(dateTime1, dateTime2).TotalDays;
        }
        
        private static long getElapsedTicks(DateTime dateTime1, DateTime dateTime2)
        {
        	return dateTime2.Ticks - dateTime1.Ticks;
        }
        
        private static TimeSpan createTimeSpan(DateTime dateTime1, DateTime dateTime2)
        {
        	return new TimeSpan(getElapsedTicks(dateTime1, dateTime2));
        }
        */
        #endregion
    }
}