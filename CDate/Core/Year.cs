using System;

namespace CDate.Core
{
    public class Year
    {
        private int numberYear;

        public Year(int pnumberYear)
        {
            this.NumberYear = pnumberYear;
        }

        public int NumberYear
        {
            get { return numberYear; }
            set { numberYear = value; }
        }
    }
}