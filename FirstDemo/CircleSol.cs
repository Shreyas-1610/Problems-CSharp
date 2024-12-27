using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class CircleSol
    {
        public static void Perimeter(int diameter)
        {
            double radius = diameter / 2;
            double ans =2 * Math.PI * radius;
            Console.WriteLine("The perimeter of circle is: "+ans);
        }
        public static void Area(int diameter)
        {
            double radius = diameter / 2;
            double ans = Math.PI * Math.Pow(radius,2);
            Console.WriteLine("The area of circle is: " + ans);
        }

    }
}
