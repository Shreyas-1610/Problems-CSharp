using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class Smallest
    {
        public static int Difference(int[] arr)
        {
            int ans = int.MaxValue;
            int res = 0;
            Array.Sort(arr);
            foreach (int i in arr) {
                int diff = Math.Abs((i + 1) - i);
                if(diff< ans)
                {
                    res = diff;
                }
            }
            return res;  
        }
    }
}
