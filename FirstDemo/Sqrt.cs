using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class Sqrt
    {
        public static int Find(int num)
        {
            if(num<2) return num;

            int low = 1, high = num;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (mid * mid == num)
                {
                    return mid;
                }
                else if (mid * mid < num)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                } 
            }
            return high;
        }
    }
}
