using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAnnotPrac
{
    internal class HtmlVal
    {
        public static void Validity()
        {
            string pattern = @"<.*?>";
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            string[] arr = str.Split(' ');
            foreach (string s in arr) {
                Match match = Regex.Match(s, pattern);
                if (match.Success)
                {
                    Console.WriteLine($"{match.Value}");
                }
            }
        }
    }
}
