using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAnnotPrac
{
    internal class EmailVal
    {
        public static void Validity()
        {
            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();
            string pattern = @"^[a-zA-Z0-9._]+@[a-zA-Z0-9]+\.[a-zA-Z]{2,}";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(email)) {
                Console.WriteLine("Valid email");
            }
            else {
                Console.WriteLine("invalid format");
            }
        }
    }
}
