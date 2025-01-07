using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message) : base(message)
        {
        }
    }
    internal class Calculate
    {
        public static void N1N2(int n1, int n2)
        {
            if (n2 < 0)
            {
                throw new NegativeNumberException("n2 cannot be negative.");
            }
            double ans = Math.Pow(n1, n2);
            Console.WriteLine($"{n1} if multiplied itself by {n2} times is {ans}");
        }
    }
}
