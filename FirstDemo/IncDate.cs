using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class IncDate
    {
        public static void next(int year, int month, int date)
        {
            DateOnly currTime = new DateOnly(year, month, date);
            DateOnly nextDate = currTime.AddDays(1);
            Console.WriteLine($"The next date is: {nextDate}");
        }
    }
}
