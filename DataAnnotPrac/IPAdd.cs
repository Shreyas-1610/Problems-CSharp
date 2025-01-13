using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAnnotPrac
{
    internal class IPAdd
    {
        public static void Validity()
        {
            string pattern = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            Console.WriteLine("Enter IPv4 Address");
            string value = Console.ReadLine();
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(value)) {
                Console.WriteLine("Valid Ip");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
