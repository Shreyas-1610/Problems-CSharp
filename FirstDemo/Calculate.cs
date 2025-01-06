using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class Calculate
    {
        public static void N1N2(int n1, int n2)
        {
            double ans = Math.Pow(n1, n2);
            Console.WriteLine($"{n1} if multiplied itself by {n2} times is {ans}");
        }
    }
}
