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
using CDate.Exceptions;

namespace CDate.Core
{
    /// <summary>
    /// Class that represent a Week
    /// </summary>
    public class Week
    {
        /// <summary>
        /// Number of the week. Number between 1 and 52
        /// </summary>
        private int numberWeek;

        /// <summary>
        /// Constructor with the number of the week
        /// </summary>
        /// <param name="pnumberWeek">Number of the week. Number between 1 and 52</param>
        public Week(int pnumberWeek)
        {
            if (pnumberWeek <= 52 && pnumberWeek >= 1 )
            {
                this.NumberWeek = numberWeek;
            }
            else
            {
                throw new WeekException("The week number has to be greater or equal than 1 and less or equal than 52");
            }
        }

        /// <summary>
        /// Property funtion that allow get and set the property
        /// </summary>
        public int NumberWeek
        {
            get { return numberWeek; }
            set { numberWeek = value; }
        }
    }
}