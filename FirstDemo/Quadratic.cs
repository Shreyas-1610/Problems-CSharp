using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class Quadratic
    {
        public static void Equation(double a, double b, double c)
        {
            double discriminant = (b * b) - (4 * a * c);

            switch (discriminant)
            {
                case > 0:
                    double root1 = (-b + Math.Sqrt(discriminant))/(2*a);
                    double root2 = (-b - Math.Sqrt(discriminant))/(2*a);
                    Console.WriteLine($"Root 1: {root1}");
                    Console.WriteLine($"Root 2: {root2}");
                    break;
                case 0:
                    double root = -b/(2*a);
                    Console.WriteLine($"The root is: {root}");
                    break ;
                default:
                    double real = -b / (2 * a);
                    double imagine = Math.Sqrt(discriminant)/(2*a);
                    Console.WriteLine($"Real number: {real} and imaginary: {imagine}");
                    break;
            }
        }
    }
}
