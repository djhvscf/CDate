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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CDate.Exceptions;

namespace CDate.Core
{
    /// <summary>
    /// Class that represent a Second
    /// </summary>
    public class Second
    {
        /// <summary>
        /// Number of the second. Number between 0 and 59
        /// </summary>
        private int _second;

        /// <summary>
        /// Constructor with the number of the second.
        /// </summary>
        /// <param name="psecond">Number of the second. Number between 0 and 59</param>
        public Second(int psecond)
        {
            if (psecond >= 0 && psecond <= 59)
            {
                this._Second = psecond;
            }
            else
            {
                throw new SecondException("The second number has to be greater or equal than 0 and less or equal than 59");
            }
        }

        /// <summary>
        /// Property function that allow get and set the property
        /// </summary>
        public int _Second
        {
            get { return _second; }
            set { _second = value; }
        }
    }
}