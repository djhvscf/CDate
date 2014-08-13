using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CDate.Core
{
    public class Millisecond
    {
        private long millisecond;

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

        public long Millisecond
        {
            get { return millisecond; }
            set { millisecond = value; }
        }
    }
}