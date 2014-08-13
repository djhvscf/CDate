using CDate.Enums;

namespace CDate.Core
{
    public class Month
    {
        private Months month;

        public Month(Months pmonth)
        {
            this.Month = pmonth;
        }

        public Months Month
        {
            get { return month; }
            set { month = value; }
        }
    }
}