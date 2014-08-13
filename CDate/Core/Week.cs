using System;

namespace CDate.Core
{
    public class Week
    {
        private int numberWeek;

        public Week() { }

        public Week(int pnumberWeek)
        {
            if (pnumberWeek <= 52 && pnumberWeek >= 1 )
            {
                this.NumberWeek = numberWeek;
            }
            else
            {
                throw new Exception();//TODO Date Range Exception
            }
        }

        public int NumberWeek
        {
            get { return numberWeek; }
            set { numberWeek = value; }
        }
    }
}