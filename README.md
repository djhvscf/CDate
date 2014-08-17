CDate
=====

A Modern C# Date Library

Author Homepage:      http://djhv92.wix.com/dennishernandez<br />

How to use it?
==============

        CDate.Core.CDate dateString = new CDate.Core.CDate("16/08/2000 07:23:17 a.m."); //New CDate object with String Date
		CDate.Core.CDate dateTimeNow = new CDate.Core.CDate(DateTime.Now); //New CDate object with DateTime Date
		
        Console.WriteLine(dateString.getDate_MM_dd_yy()); //Print 08/16/00 
		Console.WriteLine(dateString.getDate_MM_dd_yyyy()); //Print 08/16/2000
	    
Main Functions
=============
.getDate_MM_dd_yy() -> Return the date in format MM/dd/yy.

.getDate_MM_dd_yyyy() -> Return the date in format MM/dd/yyyy.

.getDate_MM_dd_yy_HH_mm_ss() -> Return the date in format MM/dd/yy HH:mm:ss and the hour in 24 format.

.getDate_MM_dd_yyyy_HH_mm_ss() -> Return the date in format MM/dd/yyyy HH:mm:ss and the hour in 24 format.

.getDate_MM_dd_yy_hh_mm_ss(boolean) -> Return the date in format MM/dd/yy hh:mm:ss and the hour in 12 format and boolean if you want include AMPM or not.

.getDate_MM_dd_yyyy_hh_mm_ss(boolean) -> Return the date in format MM/dd/yyyy hh:mm:ss and the hour in 12 format and boolean if you want include AMPM or not.

.getDate_dd_MM_yy() -> Return the date in format dd/MM/yy.

.getDate_dd_MM_yyyy() -> Return the date in format dd/MM/yyyy.

.getDate_dd_MM_yy_HH_mm_ss() -> Return the date in format dd/MM/yy HH:mm:ss and the hour in 24 format.

.getDate_dd_MM_yyyy_HH_mm_ss() -> Return the date in format dd/MM/yyyy HH:mm:ss and the hour in 24 format.

.getDate_dd_MM_yy_hh_mm_ss(boolean) -> Return the date in format dd/MM/yy hh:mm:ss and the hour in 12 format and boolean if you want include AMPM or not.

.getDate_dd_MM_yyyy_hh_mm_ss(boolean) -> Return the date in format dd/MM/yyyy hh:mm:ss and the hour in 12 format and boolean if you want include AMPM or not.

.getYear() -> Return the year in 4 digits.

.getHour(boolean) -> Return the hour of the date. True to include AMPM or false no include AMPM.

.getHour24Format() -> Return the hour of a date in 24 format.

.getMonthNumber() -> Return the month number. 1 to 31.

.getMonthName() -> Return the month name.

.getDayNumber() -> Return the day number.

.getDayName() -> Return the day name.

.getWeek() -> Return the week number. 1 to 52.

.getMinute() -> Return the minutes of the date.

.getSecond() -> Return the seconds of the date.

.getMillisecond() -> Return the millisecond of the date.

Release history
======================
Version: 1.0.0 - 16-August-2014

Download CDate.dll
=======================
https://github.com/djhvscf/CDate/releases/tag/v1.0.0