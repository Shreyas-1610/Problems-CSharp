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
            Array.Sort(arr);
            for(int i =1;i<arr.Length;i++) {
                int diff = arr[i] - arr[i - 1];
                if(diff< ans)
                {
                    ans = diff;
                }
            }
            return ans;  
        }
    }
}
