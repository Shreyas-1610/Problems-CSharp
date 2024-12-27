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
            DateTime currTime = new DateTime(year, month, date);
            DateTime nextDate = currTime.AddDays(1);
            Console.WriteLine($"The next date is  in the format(yyyy-mm-dd): {nextDate:yyyy-mm-dd}");
        }
    }
}
