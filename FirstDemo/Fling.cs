using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class Fling
    {
        public static void Flang()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string res = "";
            if (number % 3 == 0)
            {
                res += "Pling";
            }
            if (number % 5 == 0)
            {
                res += "Plang";
            }
            if (number % 7 == 0)
            {
                res += "Plong";
            }
            if (string.IsNullOrEmpty(res))
            {
                res = number.ToString();
            }
            Console.WriteLine("Result: "+res);
        }
    }
}
