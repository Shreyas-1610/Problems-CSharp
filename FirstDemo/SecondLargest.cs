using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class SecondLargest
    {
        public static int SLarge(int[] arr)
        {
            int large = int.MinValue;
            int sLarge = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > large) {
                    sLarge = large;
                    large = arr[i];
                }
                else if (arr[i] > sLarge && arr[i] != large)
                {
                    sLarge = arr[i];
                }
            }
            return sLarge;
            }
    }
}
