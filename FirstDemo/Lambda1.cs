using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class Lambda1
    {
        public static void impl()
        {
            List<int> list = new List<int>() { 2,-4,3,9,6,80,12,-90,36};
            var pos = (from num in list where num > 0 where num%3==0 select num).OrderBy(n=>n);
            foreach(var n in pos) Console.WriteLine(n);
            
        }

        public static void impl2()
        {
            int[] arr = new int[10] { 1,2,3,4,5,6,7,8,9,10};
            var square = arr.Select(n => new { num = n, square = n * n });
            foreach(var i in square)
            {
                Console.WriteLine($"{i.square}");
            }
        }
    }
}
