using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class WithoutLoop
    {
        public static void PrintNumber(int num)
        {
            if (num <= 100)
            {
                Console.WriteLine(num);
                PrintNumber(num + 1);
            }
        }
    }
}
