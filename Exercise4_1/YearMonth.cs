using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class YearMonth
    {
        public int Year { get; private set; }
        public int Month { get; private set; }
        public bool Is21Century => (2001 <= Year && Year <= 2100);

        public YearMonth(int year, int month)
        {
            Year = year;
            Month = month;
        }

        public YearMonth AddOneMonth()
        {
            int year;
            int month;

            if (Month == 12) {
                year = Year + 1;
                month = 1;
            }
            else
            {
                year = Year;
                month = Month + 1;
            }

            var oneMonthLater = new YearMonth(year, month);
            return oneMonthLater;
        }

        public override string ToString()
        {
            return $"{Year}年{Month}月";
        }
    }
}
