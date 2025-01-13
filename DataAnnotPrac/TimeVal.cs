using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAnnotPrac
{
    internal class TimeVal
    {
        public static void Validity()
        {
            string pattern = @"^(0[1-9]|1[0-2]):[0-5][0-9]\s+(AM|PM)";
            Console.WriteLine("Enter time");
            string time = Console.ReadLine();
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(time)) {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
