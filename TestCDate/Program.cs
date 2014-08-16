/*
 * Created by SharpDevelop.
 * User: Dennis
 * Date: 15/08/2014
 * Time: 09:06 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using CDate.Core;

namespace TestCDate
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			CDate.Core.CDate date = new CDate.Core.CDate(DateTime.Now);
			CDate.Core.CDate dateString = new CDate.Core.CDate("16/08/2000 07:23:17 a.m.");
			Console.WriteLine(DateTime.Now);
			Console.WriteLine("_________________________________");
			Console.WriteLine(date.getDate_MM_dd_yy());
			Console.WriteLine(date.getDate_MM_dd_yyyy());
			Console.WriteLine("_________________________________");
			Console.WriteLine(date.getDate_MM_dd_yy_HH_mm_ss());
			Console.WriteLine(date.getDate_MM_dd_yyyy_HH_mm_ss());
			Console.WriteLine(date.getDate_MM_dd_yy_hh_mm_ss(true));
			Console.WriteLine(date.getDate_MM_dd_yyyy_hh_mm_ss(true));
			Console.WriteLine("_________________________________");
			Console.WriteLine(date.getDate_MM_dd_yy_HH_mm_ss());
			Console.WriteLine(date.getDate_MM_dd_yyyy_HH_mm_ss());
			Console.WriteLine(date.getDate_MM_dd_yy_hh_mm_ss(false));
			Console.WriteLine(date.getDate_MM_dd_yyyy_hh_mm_ss(false));
			Console.WriteLine("_________________________________");
			Console.WriteLine(date.getDate_dd_MM_yy());
			Console.WriteLine(date.getDate_dd_MM_yyyy());
			Console.WriteLine("_________________________________");
			Console.WriteLine(date.getDate_dd_MM_yy_HH_mm_ss());
			Console.WriteLine(date.getDate_dd_MM_yyyy_HH_mm_ss());
			Console.WriteLine(date.getDate_dd_MM_yy_hh_mm_ss(true));
			Console.WriteLine(date.getDate_dd_MM_yyyy_hh_mm_ss(true));
			Console.WriteLine("_________________________________");
			Console.WriteLine(date.getDate_dd_MM_yy_HH_mm_ss());
			Console.WriteLine(date.getDate_dd_MM_yyyy_HH_mm_ss());
			Console.WriteLine(date.getDate_dd_MM_yy_hh_mm_ss(false));
			Console.WriteLine(date.getDate_dd_MM_yyyy_hh_mm_ss(false));
			Console.WriteLine("_________________________________");
			Console.WriteLine(date.getYear());
			Console.WriteLine(date.getMonthNumber());
			Console.WriteLine(date.getMonthName());
			Console.WriteLine(date.getDayNumber());
			Console.WriteLine(date.getDayName());
			Console.WriteLine(date.getWeek());
			Console.WriteLine(date.getHour(true));
			Console.WriteLine(date.getHour(false));
			Console.WriteLine(date.getHour24Format());
			Console.WriteLine(date.getMinute());
			Console.WriteLine(date.getSecond());
			Console.WriteLine(date.getMillisecond());
			Console.WriteLine("_________________________________");
			
			Console.WriteLine("_________________________________");
			Console.WriteLine(dateString.getDate_MM_dd_yy());
			Console.WriteLine(dateString.getDate_MM_dd_yyyy());
			Console.WriteLine("_________________________________");
			Console.WriteLine(dateString.getDate_MM_dd_yy_HH_mm_ss());
			Console.WriteLine(dateString.getDate_MM_dd_yyyy_HH_mm_ss());
			Console.WriteLine(dateString.getDate_MM_dd_yy_hh_mm_ss(true));
			Console.WriteLine(dateString.getDate_MM_dd_yyyy_hh_mm_ss(true));
			Console.WriteLine("_________________________________");
			Console.WriteLine(dateString.getDate_MM_dd_yy_HH_mm_ss());
			Console.WriteLine(dateString.getDate_MM_dd_yyyy_HH_mm_ss());
			Console.WriteLine(dateString.getDate_MM_dd_yy_hh_mm_ss(false));
			Console.WriteLine(dateString.getDate_MM_dd_yyyy_hh_mm_ss(false));
			Console.WriteLine("_________________________________");
			Console.WriteLine(dateString.getDate_dd_MM_yy());
			Console.WriteLine(dateString.getDate_dd_MM_yyyy());
			Console.WriteLine("_________________________________");
			Console.WriteLine(dateString.getDate_dd_MM_yy_HH_mm_ss());
			Console.WriteLine(dateString.getDate_dd_MM_yyyy_HH_mm_ss());
			Console.WriteLine(dateString.getDate_dd_MM_yy_hh_mm_ss(true));
			Console.WriteLine(dateString.getDate_dd_MM_yyyy_hh_mm_ss(true));
			Console.WriteLine("_________________________________");
			Console.WriteLine(dateString.getDate_dd_MM_yy_HH_mm_ss());
			Console.WriteLine(dateString.getDate_dd_MM_yyyy_HH_mm_ss());
			Console.WriteLine(dateString.getDate_dd_MM_yy_hh_mm_ss(false));
			Console.WriteLine(dateString.getDate_dd_MM_yyyy_hh_mm_ss(false));
			Console.WriteLine("_________________________________");
			Console.WriteLine(dateString.getYear());
			Console.WriteLine(dateString.getMonthNumber());
			Console.WriteLine(dateString.getMonthName());
			Console.WriteLine(dateString.getDayNumber());
			Console.WriteLine(dateString.getDayName());
			Console.WriteLine(dateString.getWeek());
			Console.WriteLine(dateString.getHour(true));
			Console.WriteLine(dateString.getHour(false));
			Console.WriteLine(dateString.getMinute());
			Console.WriteLine(dateString.getSecond());
			Console.WriteLine(dateString.getMillisecond());
			Console.WriteLine("_________________________________");
			Console.Write("Exit ");
			Console.ReadKey(true);
		}
	}
}