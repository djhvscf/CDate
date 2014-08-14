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

namespace CDate.Core
{
    /// <summary>
    /// Class that represent a Millisecond
    /// </summary>
    public class Millisecond
    {
        /// <summary>
        /// Number of the millisecond. Number between 0 and 999
        /// </summary>
        private long millisecond;

        /// <summary>
        /// Constructor with the number of the millisecond
        /// </summary>
        /// <param name="pmillisecond">Number of the millisecond. Number between 0 and 999</param>
        public Millisecond(long pmillisecond)
        {
            if (pmillisecond >= 0 && pmillisecond <= 999)
            {
                this.Millisecond = pmillisecond;
            }
            else
            {
                throw new Exception(); //Millisecond range exception
            }
        }

        /// <summary>
        /// Property function that allow get and set the property
        /// </summary>
        public long Millisecond
        {
            get { return millisecond; }
            set { millisecond = value; }
        }
    }
}