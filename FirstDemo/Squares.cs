using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class Squares
    {
        public static void SquaresSum(float x, float y)
        {
            float total = x + y;
            double totalSquare = Math.Pow(total, 2);
            Console.WriteLine($"The square of the two numbers are: {totalSquare}");
        }

        public static void SquareDiff(float x, float y)
        {
            float diff = x - y;
            double diffSquare = Math.Pow(diff, 2);
            Console.WriteLine($"The square of difference is: {diffSquare}");
        }
    }
}
