using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAnnotPrac
{
    internal class NumberVal
    {
        public static void Validity()
        {
            string pattern = @"\d{1,}";
            Console.WriteLine("Enter string");
            string input = Console.ReadLine();
            string[] strArray = input.Split(' ');
            foreach (string str in strArray)
            {
                Match match = Regex.Match(str, pattern);
                if (match.Success)
                {
                    Console.WriteLine($"{match.Value}");
                }
            }
        }
    }
}
