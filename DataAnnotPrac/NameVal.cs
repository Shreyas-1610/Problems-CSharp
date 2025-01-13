using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAnnotPrac
{
    internal class NameVal
    {
        public static void Validity()
        {
            string pattern = @"\bshreyas\b";
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            Console.Write("'Shreyas' found at: ");
            int i = 0;
            foreach (string s in arr)
            {            
                Match match = Regex.Match(s, pattern,RegexOptions.IgnoreCase);
                if (match.Success) {
                    Console.WriteLine($"{match.Value} at index={i}");
                }
                i++;
            }
        }
    }
}
