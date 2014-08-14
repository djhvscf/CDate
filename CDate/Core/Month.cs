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
using CDate.Enums;

namespace CDate.Core
{
    /// <summary>
    /// Class that represent a Month
    /// </summary>
    public class Month
    {
        /// <summary>
        /// Month of the year
        /// </summary>
        private Months month;

        /// <summary>
        /// Represents a  first month of a Year January
        /// </summary>
       private static readonly int defaultYear = 2014;

        /// <summary>
        /// Represent a first day of a week. Sunday
        /// </summary>
        private static readonly int defaultDay = 1;

        /// <summary>
        /// Constructor with the Month
        /// </summary>
        /// <param name="pmonth">Month</param>
        public Month(Months pmonth)
        {
            this.Month = pmonth;
        }

        /// <summary>
        /// Property function that allow get and set the property
        /// </summary>
        private Months Month
        {
            get { return month; }
            set { month = value; }
        }

        /// <summary>
        /// Returns the month of the year. (0-11)
        /// Value is zero-index, meaning Jan=0, Feb=1, Mar=2, etc
        /// </summary>
        /// <returns>Month of the year</returns>
        public int getMonth()
        {
            return Convert.ToInt32(this.Month.ToString());
        }
    }
}