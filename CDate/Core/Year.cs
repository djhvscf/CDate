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

namespace CDate.Core
{
    /// <summary>
    /// Class that represent a Year
    /// </summary>
    public class Year
    {
        /// <summary>
        /// The year (1 through 9999)
        /// </summary>
        private int _numberYear;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="pnumberYear">The year (1 through 9999)</param>
        public Year(int pnumberYear)
        {
            this._NumberYear = pnumberYear;
        }

        /// <summary>
        /// Property function that allow get and set a property
        /// </summary>
        public int _NumberYear
        {
            get { return _numberYear; }
            set { _numberYear = value; }
        }

        /*/// <summary>
        /// Return the full year
        /// </summary>
        /// <returns>Year 4 digits (Ex: 2014)</returns>
        public int getFullYear(int month, int day)
        {
            return new DateTime(this.NumberYear, month, day).Year;
        }*/
    }
}