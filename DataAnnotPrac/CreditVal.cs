using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAnnotPrac
{
    internal class CreditVal
    {
        public static void Validity()
        {
            string pattern = @"^\d{4}([- ]?)\d{4}\1\d{4}\1\d{4}$";
            Console.WriteLine("Enter credit card number: ");
            string input = Console.ReadLine();
            Regex regex = new Regex(input);
            if (regex.IsMatch(input))
            {
                Console.WriteLine("Valid card");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
