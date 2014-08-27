using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDate
{
    public static  class CDateValidator
    {
        private static readonly String separatorHyphen = "-";
        private static readonly String separatorSlash = "/";
        private static String[] separators = new String[2];

        public static void validate(String date)
        {
            if (date.Contains(separatorHyphen) || date.Contains(separatorSlash))
            {
                separators[0] = separatorHyphen;
                separators[1] = separatorSlash;

                String[] dateParts = date.Split(separators, StringSplitOptions.None);
            }
            else
            {
                throw new FormatException("Date is invalid");
            }
        }
    }
}