using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAnnotPrac
{
    internal class PassVal
    {
        public static void Validity()
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(password)) 
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Weak password");
            }
        }
    }
}
