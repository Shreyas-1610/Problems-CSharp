using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class MoveZeros
    {
        public static void move(int[] arr)
        {
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[index++] = arr[i];
                }
            }
            while (index < arr.Length)
            {
                arr[index++] = 0;
            }
        }
    }
}
