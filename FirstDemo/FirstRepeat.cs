using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class FirstRepeat
    {
        public static int FindFirst(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++) {
                for (int j = i + 1; j < arr.Length; j++) {
                    if (arr[i] == arr[j]) {
                        return arr[i];                    
                    }
                }
            }
            return -1;
        }

        public static int FindFirstOpti(int[] arr)
        {
            HashSet<int> ans = new HashSet<int>();
            foreach (int i in arr)
            {
                if (ans.Contains(i))
                {
                    return i;
                }
                ans.Add(i);
            }
            return -1;
        }
    }
}
