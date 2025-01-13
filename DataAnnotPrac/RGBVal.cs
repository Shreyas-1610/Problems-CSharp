using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAnnotPrac
{
    internal class RGBVal
    {
        public static void Validity()
        {
            string pattern = @"^#([0-9a-fA-F]{3}|[0-9a-fA-F]{6})$";
            Console.WriteLine("Enter RGB/ RRGGBB with #");
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(input)) {
                Console.WriteLine("Valid RGB");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
