using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAnnotPrac
{
    internal class PhoneVal
    {
        public static void Validity()
        {
            string pattern = @"^\(\d{3}\) \d{3}-\d{4}|\d{3}-\d{3}-\d{4}$";
            Console.WriteLine("Enter phone number: ");
            string number = Console.ReadLine();
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(number))
            {
                Console.WriteLine("Valid number");
            }
            else
            {
                Console.WriteLine("invalid format");
            }

        }
    }
}
