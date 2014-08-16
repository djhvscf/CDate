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
    /// Class base to help in the exception library
    /// </summary>
    public class CDateException : Exception
    {
        /// <summary>
        /// The error message that explains the reason for the exception.
        /// </summary>
        private String _message;
        
        /// <summary>
        /// The exception that is the cause of the current exception
        /// </summary>
        private Exception _innerException;
        
        /// <summary>
        /// The object that holds the serialized object data
        /// </summary>
        private SerializationInfo _info;
        
        /// <summary>
        /// The contextual information about the source or destination
        /// </summary>
        private StreamingContext _context;
        
        /// <summary>
        /// Message default when the ExceptionCDate is initialize without message
        /// </summary>
        private static readonly String messageDefault = "Exception CDate Library";

        /// <summary>
        /// Default constructor
        /// </summary>
        public CDateException()
            : base(messageDefault){}

        /// <summary>
        /// Constructor that initialize a new ExceptionCDate with message
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public CDateException(String message)
            : base(message)
        {
            if (message.Equals(""))
            {
                this._Message = messageDefault;
            }
            else
            {
                this._Message = message;
            }
        }
    
        /// <summary>
        /// Constructor that initialize a new ExceptionCDate with Serialization Info and Streaming Context
        /// </summary>
        /// <param name="info">The object that holds the serialized object data</param>
        /// <param name="context">The contextual information about the source or destination</param>
        public CDateException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            this._Info = info;
            this._Context = context;
        }

        /// <summary>
        /// Constructor that initialize a new ExceptionCDate with message and an inner exception
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception</param>
        /// <param name="innerException">The exception that is the cause of the current exception. If the <paramref name="innerException"/> parameter is not a null reference, the current exception is raised in a catch block that handles the inner exception</param>
        public CDateException(String message, Exception innerException)
            : base(message, innerException)
        {
            this._InnerException = innerException;

            if (message.Equals(""))
            {
                this._Message = messageDefault;
            }
            else
            {
                this._Message = message;
            }
        }

        /// <summary>
        /// Property function that allow get and set the property
        /// </summary>
        private String _Message
        {
            get { return _message; }
            set { _message = value; }
        }

        /// <summary>
        /// Property function that allow get and set the property
        /// </summary>
        private Exception _InnerException
        {
            get { return _innerException; }
            set { _innerException = value; }
        }

        /// <summary>
        /// Property function that allow get and set the property
        /// </summary>
        private SerializationInfo _Info
        {
            get { return _info; }
            set { _info = value; }
        }

        /// <summary>
        /// Property function that allow get and set the property
        /// </summary>
        private StreamingContext _Context
        {
            get { return _context; }
            set { _context = value; }
        }
    }
}