/*
 Copyright (c) 2014-2015 Dennis Hernández Vargas (djhvscf)
 Permission is hereby granted, free of charge, to any person obtaining a copy
 of this software and associated documentation files (the "Software"), to deal
 in the Software without restriction, including without limitation the rights
 to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 copies of the Software, and to permit persons to whom the Software is
 furnished to do so, subject to the following conditions:
 
 The above copyright notice and this permission notice shall be included in
 all copies or substantial portions of the Software.
 
 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CDate.Enums;
using CDate.Exceptions;

namespace CDate.Core
{
    /// <summary>
    /// Class base to provide the main fuction of this library
    /// </summary>
    public class CDate
    {
        /// <summary>
        /// String for obtains the date in MM/dd/yy format
        /// </summary>
        private static readonly String formatMMddyy = "MM/dd/yy";
        
        /// <summary>
        /// String for obtains the date in dd/MM/yy format
        /// </summary>
        private static readonly String formatddMMyy = "dd/MM/yy";
        
        /// <summary>
        /// String for obtains the date in MM/dd/yyyy format
        /// </summary>
        private static readonly String formatMMddyyyy = "MM/dd/yyyy";
        
        /// <summary>
        /// String for obtains the date in dd/MM/yyyy format
        /// </summary>
        private static readonly String formatddMMyyyy = "dd/MM/yyyy";
        
        /// <summary>
        /// String for obtains the  hour in 24 format (00 to 23)
        /// </summary>
        private static readonly String format24Hour = "HH:mm:ss";
        
        /// <summary>
        /// String for obtains the hour in 12 format (1 to 12)
        /// </summary>
        private static readonly String format12Hour = "hh:mm:ss";
        
        /// <summary>
        /// String for obtains AM or PM
        /// </summary>
        private static readonly String formatAMPM = "tt";

        /// <summary>
        /// Constructor that receives a DateTime object
        /// </summary>
        /// <param name="pnativeDate">DateTime object</param>
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
        /// Constructor that receives a String that will be convert to DateTime
        /// </summary>
        /// <param name="dateString">String to convert to DateTime</param>
        public CDate(String dateString)
        {
        	this.DateString = dateString;
    		this.NativeDate = Convert.ToDateTime(dateString);
    		this.Year = new Year(this.NativeDate.Year);
        	this.Month = new Month(this.NativeDate.Month);
        	this.Day = new Day(this.NativeDate.Day);
        	this.Week = new Week();
        	this.Hour = new Hour(0);
        	this.Minute = new Minute(this.NativeDate.Minute);
        	this.Second = new Second(this.NativeDate.Second);
        	this.Millisecond = new Millisecond(this.NativeDate.Millisecond);

        }

		/// <summary>
		/// Property funtion that allow get and set the property
		/// </summary>
		public DateTime NativeDate 
		{
			get;
			set;
		}

		/// <summary>
		/// Property funtion that allow get and set the property
		/// </summary>
		private Year Year 
		{
			get;
			set;
		}

		/// <summary>
		/// Property funtion that allow get and set the property
		/// </summary>
		private Month Month 
		{
			get;
			set;
		}
                
		/// <summary>
		/// Property funtion that allow get and set the property
		/// </summary>
		private Week Week 
		{
			get;
			set;
		}

		/// <summary>
		/// Property funtion that allow get and set the property
		/// </summary>
		private Day Day 
		{
			get;
			set;
		}
        
		/// <summary>
		/// Property funtion that allow get and set the property
		/// </summary>
		private Hour Hour 
		{
			get;
			set;
		}

		/// <summary>
		/// Property funtion that allow get and set the property
		/// </summary>
		private Minute Minute 
		{
			get;
			set;
		}

		/// <summary>
		/// Property funtion that allow get and set the property
		/// </summary>
		private Second Second 
		{
			get;
			set;
		}
        
		/// <summary>
		/// Property funtion that allow get and set the property
		/// </summary>
		private Millisecond Millisecond 
		{
			get;
			set;
		}

		/// <summary>
		/// Property funtion that allow get and set the property
		/// </summary>
		private String DateString 
		{
			get;
			set;
		}
	
        /// <summary>
        /// Functions that returns a String with date in format MM/dd/yy
        /// </summary>
        /// <returns>String of a date in format MM/dd/yy</returns>
    	public String getDate_MM_dd_yy()
        {
        	return this.NativeDate.ToString(formatMMddyy);
        }
        
    	/// <summary>
        /// Functions that returns a String with date in format MM/dd/yyyy
        /// </summary>
        /// <returns>String of a date in format MM/dd/yyyy</returns>
        public String getDate_MM_dd_yyyy()
        {
        	return this.NativeDate.ToString(formatMMddyyyy);
        }
        
        /// <summary>
        /// Functions that returns a String with date and hour in format MM/dd/yy HH:mm:ss (24 Format)
        /// </summary>
        /// <returns>String of a date in format MM/dd/yy HH:mm:ss (24 Format)</returns>
        public String getDate_MM_dd_yy_HH_mm_ss()
        {
    		return this.NativeDate.ToString(formatMMddyy + " " + format24Hour);
        }
        
        /// <summary>
        /// Functions that returns a String with date and hour in format MM/dd/yyyy HH:mm:ss (24 Format)
        /// </summary>
        /// <returns>String of a date in format MM/dd/yyyy HH:mm:ss (24 Format)</returns>
        public String getDate_MM_dd_yyyy_HH_mm_ss()
        {
    		return this.NativeDate.ToString(formatMMddyyyy + " " + format24Hour);
        }
        
        /// <summary>
        /// /// Functions that returns a String with date and hour in format MM/dd/yy hh:mm:ss (12 Format)
        /// </summary>
        /// <param name="isAMPM">True -> Include the AMPM to hour, false -> No include the AMPM</param>
        /// <returns>String of a date in format MM/dd/yy HH:mm:ss (AMPM) (12 Format)</returns>
        public String getDate_MM_dd_yy_hh_mm_ss(bool isAMPM)
        {
        	return this.NativeDate.ToString(formatMMddyy + " " + format12Hour + (isAMPM ? " " + formatAMPM : ""));
        }
        
        /// <summary>
        /// /// Functions that returns a String with date and hour in format MM/dd/yyyy hh:mm:ss (12 Format)
        /// </summary>
        /// <param name="isAMPM">True -> Include the AMPM to hour, false -> No include the AMPM</param>
        /// <returns>String of a date in format MM/dd/yyyy HH:mm:ss (AMPM) (12 Format)</returns>
        public String getDate_MM_dd_yyyy_hh_mm_ss(bool isAMPM)
        {
        	return this.NativeDate.ToString(formatMMddyyyy + " " + format12Hour + (isAMPM ? " " + formatAMPM : ""));
        }
        
        /// <summary>
        /// Functions that returns a String with date in format dd/MM/yy
        /// </summary>
        /// <returns>String of a date in format dd/MM/yy</returns>
        public String getDate_dd_MM_yy()
        {
        	return this.NativeDate.ToString(formatddMMyy);
        }
        
        /// <summary>
        /// Functions that returns a String with date in format dd/MM/yyyy
        /// </summary>
        /// <returns>String of a date in format dd/MM/yyyy</returns>
        public String getDate_dd_MM_yyyy()
        {
        	return this.NativeDate.ToString(formatddMMyyyy);
        }
        
        /// <summary>
        /// Functions that returns a String with date and hour in format dd/MM/yy HH:mm:ss (24 Format)
        /// </summary>
        /// <returns>String of a date in format dd/MM/yy HH:mm:ss (24 Format)</returns>
        public String getDate_dd_MM_yy_HH_mm_ss()
        {
        	return this.NativeDate.ToString(formatddMMyy + " " + format24Hour);
        }
        
        /// <summary>
        /// Functions that returns a String with date and hour in format dd/MM/yyyy HH:mm:ss (24 Format)
        /// </summary>
        /// <returns>String of a date in format dd/MM/yyyy HH:mm:ss (24 Format)</returns>
        public String getDate_dd_MM_yyyy_HH_mm_ss()
        {
        	return this.NativeDate.ToString(formatddMMyyyy + " " + format24Hour);
        }
        
        /// <summary>
        /// /// Functions that returns a String with date and hour in format dd/MM/yy hh:mm:ss (12 Format)
        /// </summary>
        /// <param name="isAMPM">True -> Include the AMPM to hour, false -> No include the AMPM</param>
        /// <returns>String of a date in format dd/MM/yy HH:mm:ss (AMPM) (12 Format)</returns>
        public String getDate_dd_MM_yy_hh_mm_ss(bool isAMPM)
        {
        	return this.NativeDate.ToString(formatddMMyy + " " + format12Hour + (isAMPM ? " " + formatAMPM : ""));
        }
        
        /// <summary>
        /// /// Functions that returns a String with date and hour in format dd/MM/yyyy hh:mm:ss (12 Format)
        /// </summary>
        /// <param name="isAMPM">True -> Include the AMPM to hour, false -> No include the AMPM</param>
        /// <returns>String of a date in format dd/MM/yyyy HH:mm:ss (AMPM) (12 Format)</returns>
        public String getDate_dd_MM_yyyy_hh_mm_ss(bool isAMPM)
        {
        	return this.NativeDate.ToString(formatddMMyyyy + " " + format12Hour + (isAMPM ? " " + formatAMPM : ""));
        }
        
        /// <summary>
        /// Get the year of a Date (4 digits)
        /// </summary>
        /// <returns>Year with 4 digits</returns>
        public int getYear()
        {
        	return this.Year._NumberYear;
        }
        
        /// <summary>
        /// Get the month nummber of a date (1 to 12)
        /// </summary>
        /// <returns>Month number between 1 and 12</returns>
        public int getMonthNumber()
        {
        	return this.Month._Month;
        }
        
        /// <summary>
        /// Get the month name of a date
        /// </summary>
        /// <returns>Month name</returns>
        public String getMonthName()
        {
			return new System.Globalization.DateTimeFormatInfo().GetMonthName(this.Month._Month).ToString();
        }
        
        /// <summary>
        /// Get the day number of a date (1 to 31)
        /// </summary>
        /// <returns>Day number between 1 to 31</returns>
        public int getDayNumber()
        {
        	return this.Day._NumberDay;
        }
        
        /// <summary>
        /// Get the day name of a date in english version
        /// </summary>
        /// <returns>Day name</returns>
        public String getDayName()
        {
			return this.NativeDate.DayOfWeek.ToString();
			//return this.NativeDate.ToString("dddd"); Spanish
        }
        
        /// <summary>
        /// Get the week number of a date (1 to 52)
        /// </summary>
        /// <returns>Week number between 1 and 52</returns>
        public int getWeek()
        {
        	return this.Week.getWeek(this.NativeDate);
        }
        
        /// <summary>
        /// Get the hour of a date if this date include the hour, if not this function return 12:00 or 12:00 a.m.
        /// </summary>
        /// <param name="isAMPM">True -> Hour include AMPM, False -> Hour no include AMPM</param>
        /// <returns>Hour of a date</returns>
        public String getHour(bool isAMPM)
        {
			return this.NativeDate.ToString((isAMPM ? format12Hour + " " + formatAMPM : format12Hour));
        }
        
        /// <summary>
        /// Get the hour of a date if this date include the hour, if not this function return 00:00
        /// </summary>
        /// <returns>Hour if a date</returns>
        public String getHour24Format()
        {
        	return this.NativeDate.ToString(format24Hour);
        }
        
        /// <summary>
        /// Get the hour of a date if this date include the hour, if not this function return 00
        /// </summary>
        /// <returns>Minutes</returns>
        public int getMinute()
        {
        	return this.Minute._Minute;
        }
        
        /// <summary>
        /// Get the hour of a date if this date include the hour, if not this function return 00
        /// </summary>
        /// <returns>Seconds</returns>
        public int getSecond()
        {
        	return this.Second._Second;
        }
        
        /// <summary>
        /// Get the hour of a date if this date include the hour, if not this function return 00
        /// </summary>
        /// <returns>Milliseconds</returns>
        public int getMillisecond()
        {
        	return this.Millisecond._Millisecond;
        }
        
        /// <summary>
        /// Add years to the Date. This method edit the object directly. Use a new object if you need a copy
        /// </summary>
        /// <param name="years">Years to add</param>
        /// <returns>Datetime with years added</returns>
        public DateTime addYears(int years)
        {
        	return this.NativeDate.AddYears(years);
        }
        
        /// <summary>
        /// Add months to the Date. This method edit the object directly. Use a new object if you need a copy
        /// </summary>
        /// <param name="months">Months to add</param>
        /// <returns>Datetime with months added</returns>
        public DateTime addMonths(int months)
        {
        	return this.NativeDate.AddMonths(months);
        }
        
        /// <summary>
        /// Add weeks to the Date. This method edit the object directly. Use a new object if you need a copy
        /// </summary>
        /// <param name="weeks">Weeks to add</param>
        /// <returns>Datetime with weeks added</returns>
        public DateTime addWeeks(int weeks)
        {
        	return this.NativeDate.AddDays(weeks * 7);
        }
        
        /// <summary>
        /// Add hours to the Date. This method edit the object directly. Use a new object if you need a copy
        /// </summary>
        /// <param name="hours">Hours to add</param>
        /// <returns>Datetime with hours added</returns>
        public DateTime addHours(double hours)
        {
        	return this.NativeDate.AddHours(hours);
        }
        
        /// <summary>
        /// Add minutes to the Date. This method edit the object directly. Use a new object if you need a copy
        /// </summary>
        /// <param name="minutes">Minutes to add</param>
        /// <returns>Datetime with minutes added</returns>
        public DateTime addMinutes(double minutes)
        {
        	return this.NativeDate.AddMinutes(minutes);
        }
        
        /// <summary>
        /// Add seconds to the Date. This method edit the object directly. Use a new object if you need a copy
        /// </summary>
        /// <param name="seconds">Seconds to add</param>
        /// <returns>Datetime with seconds added</returns>
        public DateTime addSeconds(double seconds)
        {
        	return this.NativeDate.AddSeconds(seconds);
        }
        
        /// <summary>
        /// Add milliseconds to the Date. This method edit the object directly. Use a new object if you need a copy
        /// </summary>
        /// <param name="milliseconds">Milliseconds to add</param>
        /// <returns>Datetime with milliseconds added</returns>
        public DateTime addMilliseconds(double milliseconds)
        {
        	return this.NativeDate.AddMilliseconds(milliseconds);
        }
        
        /// <summary>
        /// Return the difference in years between main object and parameter
        /// </summary>
        /// <param name="datetime">Datetime to know the difference in years</param>
        /// <returns>Difference in years between both dates. This number could be negative</returns>
        public int diffYears(DateTime datetime)
        {
        	return (this.getYear() - datetime.Year);
        }
        
        /// <summary>
        /// Return the difference in months between main object and parameter
        /// </summary>
        /// <param name="datetime">Datetime to know the difference in months</param>
        /// <returns>Difference in months between both dates. This number could be negative</returns>
        public int diffMonths(DateTime datetime)
        {
        	return (this.getMonthNumber() - datetime.Month);
        }
        
        /// <summary>
        /// Return the difference in weeks between main object and parameter
        /// </summary>
        /// <param name="datetime">Datetime to know the difference in weeks</param>
        /// <returns>Difference in weeks between both dates. This number could be negative</returns>
        public int diffWeeks(DateTime datetime)
        {
        	return (this.getWeek() - new Week().getWeek(datetime));
        }
        
        /// <summary>
        /// Return the difference in days between main object and parameter
        /// </summary>
        /// <param name="datetime">Datetime to know the difference in days</param>
        /// <returns>Difference in days between both dates. This number could be negative</returns>
        public int diffDays(DateTime datetime)
        {
        	return (this.getDayNumber() - datetime.Day);
        }
        
        /// <summary>
        /// Return the difference in hours between main object and parameter
        /// </summary>
        /// <param name="datetime">Datetime to know the difference in hours</param>
        /// <returns>Difference in hours between both dates. This number could be negative</returns>
        public int diffHours(DateTime datetime)
        {
        	return (Convert.ToInt32(this.getHour(false)) - datetime.Hour);
        }
        
        /// <summary>
        /// Return the difference in minutes between main object and parameter
        /// </summary>
        /// <param name="datetime">Datetime to know the difference in minutes</param>
        /// <returns>Difference in minutes between both dates. This number could be negative</returns>
        public int diffMinutes(DateTime datetime)
        {
        	return (this.getMinute() - datetime.Minute);
        }
        
        /// <summary>
        /// Return the difference in seconds between main object and parameter
        /// </summary>
        /// <param name="datetime">Datetime to know the difference in seconds</param>
        /// <returns>Difference in seconds between both dates. This number could be negative</returns>
        public int diffSeconds(DateTime datetime)
        {
        	return (this.getSecond() - datetime.Second);
        }
        
        /// <summary>
        /// Return the difference in milliseconds between main object and parameter
        /// </summary>
        /// <param name="datetime">Datetime to know the difference in milliseconds</param>
        /// <returns>Difference in milliseconds between both dates. This number could be negative</returns>
        public int diffMilliseconds(DateTime datetime)
        {
        	return (this.getMillisecond() - datetime.Millisecond);
        }
    }
}