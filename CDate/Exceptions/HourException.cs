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
using System.Runtime.Serialization;
using System.Text;

namespace CDate.Exceptions
{
    /// <summary>
    /// Class that help with hour exceptions
    /// </summary>
    public class HourException : CDateException
    {
        /// <summary>
        /// Message default when the HourException is initialize without message
        /// </summary>
        private static readonly String messageDefault = "Hour exception was ocurred";

        /// <summary>
        /// Default constructor
        /// </summary>
        public HourException()
            : base(messageDefault)
        {
        }

        /// <summary>
        /// Constructor that initialize a new HourException with message
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public HourException(String message)
            : base(message)
        {
        }

        /// <summary>
        /// Constructor that initialize a new HourException with Serialization Info and Streaming Context
        /// </summary>
        /// <param name="info">The object that holds the serialized object data</param>
        /// <param name="context">The contextual information about the source or destination</param>
        public HourException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Constructor that initialize a new HourException with message and an inner exception
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception</param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException"/> parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception</param>
        public HourException(String message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}