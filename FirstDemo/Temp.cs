using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class Temp
    {
        public static void Converssion(int c)
        {
            int kelvin = c + 273;

            int fah = c * 18 / 10 + 32;
            Console.WriteLine($"Temperature in celsius: {c} is same as {fah} in Fahrenheit \n and {kelvin} in Kelvin.");
        }
    }
}
