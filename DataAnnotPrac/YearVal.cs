using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAnnotPrac
{
    internal class YearVal
    {
        public static void Validity()
        {
            Console.WriteLine("Enter date in MM/DD/YYYY:");
            string year = Console.ReadLine();
            string pattern = @"^(0[1-9]|1[0-2])/(0[1-9]|[12][0-9]|3[01])/\d\d\d\d$";
            if (!Regex.IsMatch(year, pattern)) 
            {
                Console.WriteLine("Invalid format");
            }
            string[] parts = year.Split('/');
            int month = int.Parse(parts[0]);
            int day = int.Parse(parts[1]);
            int years = int.Parse(parts[2]);

            if(day < 1 || day > DateTime.DaysInMonth(years, month))
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Valid Data");
            }
        }
    }
}
