using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class RemoveArray
    {
        public static int[] ArrElement(int[] arr, int element)
        {
            int n=arr.Length;
            int j = 0;
            int[] temp = new int[n-1];
            for(int i =0; i < n; i++)
            {
                if(i == element)
                {
                    continue;
                }
                temp[j]=arr[i];
                j++;
            }
            return temp;
        }
    }
}
