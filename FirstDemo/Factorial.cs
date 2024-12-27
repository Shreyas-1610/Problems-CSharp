using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class Factorial
    {
        public static void Fact(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            Console.WriteLine($"The factorial of {num} is {fact}");
        }
    }
}
