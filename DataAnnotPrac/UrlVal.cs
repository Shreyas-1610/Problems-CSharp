using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAnnotPrac
{
    internal class UrlVal
    {
        public static void Validity()
        {
            string pattern = @"^((?:https?|ftp):\/\/(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9]{2,})$";
            Console.WriteLine("Enter url");
            string url = Console.ReadLine();
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(url))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid url");
            }
        }
    }
}
