using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDate.Core
{
    public class Second
    {
        private int second;

        public Second(int psecond)
        {
            if (psecond >= 0 && psecond <= 59)
            {
                this.Second = psecond;
            }
            else
            {
                throw new Exception(); //Second range exception
            }
        }

        public int Second
        {
            get { return second; }
            set { second = value; }
        }
    }
}