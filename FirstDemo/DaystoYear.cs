using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class DaystoYear
    {
        public static void ConvertDays(int totalDays)
        {
            int years = totalDays / 365; //400 = 1
            int remain = totalDays % 365; //400 = 35
            int months = remain / 30; //35 = 1
            int days = remain % 30;//35 = 5

            Console.WriteLine($"{totalDays} days = {years} years, {months} months, and {days} days.");
        }
    }
}
