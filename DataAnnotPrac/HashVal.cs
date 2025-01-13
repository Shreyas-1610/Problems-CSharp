using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAnnotPrac
{
    internal class HashVal
    {
        public static void Validity()
        {
            string pattern = @"#\w+";
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            string[] str = input.Split(" ");
            Console.Write("Hashtags in the string: ");
            foreach(string i in str)
            {
                Match match = Regex.Match(i, pattern);
                if (match.Success) {
                    Console.WriteLine($"{match.Value}");
                }
            }
        }
    }
}
