using System;

namespace CDate.Core
{
    private class Minute
    {
        private int minute;

        public Minute(int pminute)
        {
            if (pminute >= 0 && pminute <= 59)
            {
                this.Minute = pminute;
            }
            else
            {
                throw new Exception(); //TODO Minute Range exception
            }
        }

        public int Minute
        {
            get { return minute; }
            set { minute = value; }
        }
    }
}