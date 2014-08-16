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
    /// Class that represent a Minute
    /// </summary>
    public class Minute
    {
        /// <summary>
        /// Number of the minute. Number between 0 and 59
        /// </summary>
        private int _minute;

        /// <summary>
        /// Constructor with the number of the minute
        /// </summary>
        /// <param name="pminute">Number of the minute. Number between 0 and 59</param>
        public Minute(int pminute)
        {
            if (pminute >= 0 && pminute <= 59)
            {
                this._Minute = pminute;
            }
            else
            {
                throw new MinuteException("The minute number has to be greater or equal than 0 and less or equal than 59");
            }
        }

        /// <summary>
        /// Property function that allow get and set the property
        /// </summary>
        public int _Minute
        {
            get { return _minute; }
            set { _minute = value; }
        }
    }
}