using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class Average
    {
        public static float FloatAvg(float[] arr)
        {
            float total = 0;
            foreach(float num in arr)
            {
                total+= num;
            }
            return total / arr.Length;
        }
    }
}
