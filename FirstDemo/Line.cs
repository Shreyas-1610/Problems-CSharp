using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class Line
    {
        public static void FindSingleLine()
        {
            Console.WriteLine("Enter x1:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y1:");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter x2:");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2:");
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter x3:");
            int x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y3:");
            int y3 = int.Parse(Console.ReadLine());

            int s1 = (y2 - y1) / (x2 - x1);
            int s2 = (y3 - y2) / (x3 - x2);

            if(s1 == s2)
            {
                Console.WriteLine("The points lie in a single line");
            }
            else
            {
                Console.WriteLine("Not in a single line");
            }
        }
    }
}
