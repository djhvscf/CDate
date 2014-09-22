﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CDate
{
    public static class CDateValidator
    {
    	private static readonly String[] formatParts = {"-", "/", ":", "d", "M", "y", "h", "H", "s", "tt", "GMT"};
    	private static readonly String separatorHyphen = "-";
        private static readonly String separatorSlash = "/";
        private static readonly String separatorTwoPoints = ":";
        private static readonly String dayAbbr = "d";
        private static readonly String monthAbbr = "M";
        private static readonly String yearAbbr = "y";
        private static readonly String hourAbbr = "h";
        private static readonly String HourAbbr = "H";
        private static readonly String secondAbbr = "s";
        private static readonly String ampmAbbr = "tt";
        private static readonly String GMT = "GMT";
        
        public static bool validateSomething(String date, String[] format)
        {
        	String formatToConvert = formString(getValidStrings(format));
        	return false;
        }
        
        private static String[] getValidStrings(String[] format)
        {
        	List<String> validStrings = new List<string>();
        	
        	for(int i = 0; i < format.Length; i++)
        	{
        		if(formatParts.Contains(format[i]))
    		   	{
        			validStrings.Add(format[i]);
    		   	}
        	}
        	
        	return validStrings.ToArray();
        }
        
        private static String formString(String[] format)
        {
        	String formatString = "";
        	for(int i = 0; i < format.Length; i++)
        	{
        		formatString += format[i].ToString() + separatorSlash;
        	}
        	
        	return formatString.Remove(formatString.LastIndexOf(separatorSlash), 1);
        }
        
        public static bool validateStringToDateTime(String date, String format)
        {
        	date = "2006-08-22T06:30:07.7199222-04:00";
        	
        	string[] formats= {"MM/dd/yyyy", 
        						"dd/MM/yyyy",
        						"dddd, dd MMMM yyyy",
               					"dddd, dd MMMM yyyy	HH:mm", 
               					"dddd, dd MMMM yyyy	hh:mm tt",
                   				"dddd, dd MMMM yyyy	H:mm", 
                   				"dddd, dd MMMM yyyy	h:mm tt",
                   				"dddd, dd MMMM yyyy HH:mm:ss", 
                   				"MM/dd/yyyy HH:mm",
               					"MM/dd/yyyy hh:mm tt",
				   				"MM/dd/yyyy H:mm",
    							"MM/dd/yyyy h:mm tt",
						    	"MM/dd/yyyy HH:mm:ss","MMMM dd", 
						    	"dd/MM/yyyy HH:mm",
               					"dd/MM/yyyy hh:mm tt",
				   				"dd/MM/yyyy H:mm",
    							"dd/MM/yyyy h:mm tt",
						    	"dd/MM/yyyy HH:mm:ss tt","MMMM dd",
						    	"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",
						    	"ddd, dd MMM yyyy HH':'mm':'ss 'GMT'", 
						    	"yyyy'-'MM'-'dd'T'HH':'mm':'ss",
						    	"HH:mm", 
						    	"hh:mm tt", 
						    	"H:mm", 
						    	"H:mm tt", 
						    	"HH:mm:ss", 
						    	"yyyy'-'MM'-'dd HH':'mm':'ss'Z'",
						    	"dddd, dd MMMM yyyy HH:mm:ss", 
						    	"yyyy MMMM"};
    		
        	DateTime dateValidate;
    		
    		return DateTime.TryParseExact(date, formats, String.IsNullOrEmpty(format) ? CultureInfo.InvariantCulture : new CultureInfo(format), DateTimeStyles.None, out dateValidate);
        }
   	}
}