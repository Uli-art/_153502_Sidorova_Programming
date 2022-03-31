using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.Date
{
    public class DateServices
    {
        public static DayOfWeek GetDay(DateTime date)
        {
            return date.DayOfWeek;
        }
        public static int GetDaysSpan(int day, int month, int year, DateTime currentDate)
        {
            DateTime date = new DateTime(year, month, day);
            TimeSpan span = currentDate - date;
            return span.Days;
        }
    }
}
