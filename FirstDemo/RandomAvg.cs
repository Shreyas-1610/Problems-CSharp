using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class RandomAvg
    {
        public static void Average()
        {
            int total = 0;
            Random random = new Random();
            Console.Write("The numbers are: ");
            for(int i = 0; i < 5; i++)
            {
              int cnt = random.Next(10,51);
                Console.Write(cnt+" ");
                total += cnt;
            }
            Console.WriteLine();
            int avg = total / 5;
            Console.WriteLine("The average is: "+avg);
        }
    }
}
