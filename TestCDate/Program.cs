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
			Console.WriteLine(DateTime.Now);
			Console.WriteLine("_________________________________");
			Console.WriteLine(date.getDate_MM_dd_yy());
			Console.WriteLine(date.getDate_MM_dd_yyyy());
			Console.WriteLine("_________________________________");
			Console.WriteLine(date.getDate_MM_dd_yy_HH_mm_ss(true));
			Console.WriteLine(date.getDate_MM_dd_yyyy_HH_mm_ss(true));
			Console.WriteLine(date.getDate_MM_dd_yy_hh_mm_ss(true));
			Console.WriteLine(date.getDate_MM_dd_yyyy_hh_mm_ss(true));
			Console.WriteLine("_________________________________");
			Console.WriteLine(date.getDate_MM_dd_yy_HH_mm_ss(false));
			Console.WriteLine(date.getDate_MM_dd_yyyy_HH_mm_ss(false));
			Console.WriteLine(date.getDate_MM_dd_yy_hh_mm_ss(false));
			Console.WriteLine(date.getDate_MM_dd_yyyy_hh_mm_ss(false));
			Console.WriteLine("_________________________________");
			Console.WriteLine(date.getDate_dd_MM_yy());
			Console.WriteLine(date.getDate_dd_MM_yyyy());
			Console.WriteLine("_________________________________");
			Console.WriteLine(date.getDate_dd_MM_yy_HH_mm_ss(true));
			Console.WriteLine(date.getDate_dd_MM_yyyy_HH_mm_ss(true));
			Console.WriteLine(date.getDate_dd_MM_yy_hh_mm_ss(true));
			Console.WriteLine(date.getDate_dd_MM_yyyy_hh_mm_ss(true));
			Console.WriteLine("_________________________________");
			Console.WriteLine(date.getDate_dd_MM_yy_HH_mm_ss(false));
			Console.WriteLine(date.getDate_dd_MM_yyyy_HH_mm_ss(false));
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
			Console.WriteLine(date.getMinute());
			Console.WriteLine(date.getSecond());
			Console.WriteLine(date.getMillisecond());
			Console.WriteLine("_________________________________");
			
			Console.Write("Exit ");
			Console.ReadKey(true);
		}
	}
}