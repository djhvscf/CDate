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
using System.Reflection;
using CDate.Enums;

namespace CDate.Core
{
    /// <summary>
    /// Class that represent a Day of an week
    /// </summary>
    ///
    public class Day
    {
        /// <summary>
        /// Name of the new Day
        /// </summary>
        private Days _nameDay;

        /// <summary>
        /// Number of a day in a month
        /// </summary>
        private int _numberDay;

        /// <summary>
        /// Constructor that receive a Day name
        /// </summary>
        /// <param name="pnameDay">Day name</param>
        public Day(Days pnameDay)
        {
            this._NameDay = pnameDay;
        }

        /// <summary>
        /// Constructor that receive a number Day
        /// </summary>
        /// <param name="pnumberDay">Number of a day</param>
        public Day(int pnumberDay)
        {
            this._NumberDay = pnumberDay;
        }

        /// <summary>
        /// Property function that allow set and get the property
        /// </summary>
        private Days _NameDay
        {
            get { return _nameDay; }
            set { _nameDay = value; }
        }

        /// <summary>
        /// Property function that allow set and get the property
        /// </summary>
        public int _NumberDay
        {
            get { return _numberDay; }
            set { _numberDay = value; }
        }

        /*/// <summary>
        /// Returns the date of the month. (1-31)
        /// </summary>
        /// <returns>Number of the day between 1 and 31</returns>
        public int getDate(int year, int month)
        {
            return new DateTime(year, month, this.NumberDay).Day;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int getDay()
        {
            int dayToReturn = -1;

            foreach (int i in Enum.GetValues(typeof(Days)))
            {
                if (i == this.NumberDay)
                {
                    dayToReturn = i;
                }
            }

            return dayToReturn;
        }*/
    }
}