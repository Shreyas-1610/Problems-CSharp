using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAnnotPrac
{
    internal class ReplaceMult
    {
        public static void spaces()
        {
            Console.WriteLine("Enter a string with multiple spaces: ");
            string str = Console.ReadLine();
            string pattern = @"\s+";
            string replace = " ";
            string op = Regex.Replace(str,pattern,replace);
            Console.WriteLine($"String without multiple spaces:\n{op}");
        }
    }
}
