using CDate.Enums;

namespace CDate.Core
{
    public class Day
    {
        private Days nameDay;

        public Day(){}

        public Day(Days pnameDay)
        {
            this.NameDay = pnameDay;
        }

        public Days NameDay
        {
            get { return nameDay; }
            set { nameDay = value; }
        }
    }
}