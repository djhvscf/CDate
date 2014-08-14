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
    /// Class that represent a Day of an week
    /// </summary>
    ///
    public class Day
    {
        /// <summary>
        /// Name of the new Day
        /// </summary>
        private Days nameDay;

        /// <summary>
        /// Constructor that receive a Day name
        /// </summary>
        /// <param name="pnameDay">Day name</param>
        public Day(Days pnameDay)
        {
            this.NameDay = pnameDay;
        }

        /// <summary>
        /// Property function that allow set and get the property
        /// </summary>
        public Days NameDay
        {
            get { return nameDay; }
            set { nameDay = value; }
        }
    }
}