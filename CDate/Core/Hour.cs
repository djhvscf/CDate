using System;

namespace CDate.Core
{
    public class Hour
    {
        private int hour;

        public Hour(int phour)
        {
            if (phour >= 0 && phour <= 23)
            {
                this.Hour = phour;
            }
            else
            {
                throw new Exception(); //TODO Hour range Exception
            }
        }

        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }
    }
}