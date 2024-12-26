using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class Quadratic
    {
        public static void Equation(double num1, double num2, double num3)
        {
            double discriminant = (num2 * num2) - (4 * num1 * num3);

            switch (discriminant)
            {
                case > 0:
                    double root1 = (-num2 + Math.Sqrt(discriminant))/(2*num1);
                    double root2 = (-num2 - Math.Sqrt(discriminant))/(2*num1);
                    Console.WriteLine($"Root 1: {root1}");
                    Console.WriteLine($"Root 2: {root2}");
                    break;
                case 0:
                    double root = -num2/(2*num1);
                    Console.WriteLine($"The root is: {root}");
                    break ;
                default:
                    double real = -num2 / (2 * num1);
                    double imagine = Math.Sqrt(discriminant)/(2*num1);
                    Console.WriteLine($"Real number: {real} and imaginary: {imagine}");
                    break;
            }
        }
    }
}
