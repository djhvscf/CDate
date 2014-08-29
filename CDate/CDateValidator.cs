using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CDate
{
    public static class CDateValidator
    {
    	private static readonly String separatorHyphen = "-";
        private static readonly String separatorSlash = "/";
        
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