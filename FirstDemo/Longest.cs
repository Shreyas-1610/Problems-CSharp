using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class Longest
    {
        public static void SubString(string s)
        {
            int n = s.Length;
            int l = 0, r = 0;
            HashSet<char> set = new HashSet<char>();
            int maxStr = 0;
            int maxL = 0, maxR = 0;
            while (r < n)
            {
                if (!set.Contains(s[r]))
                {
                    set.Add(s[r]);
                    if (r - l + 1 > maxStr)
                    {
                        maxStr = r - l + 1;
                        maxL = l;
                        maxR = r;
                    }
                    r++;
                }
                else
                {
                    set.Remove(s[l]);
                    l++;
                }
            }
            for (int i = maxL; i <= maxR; i++)
            {
                Console.Write(s[i]);
            }
            Console.WriteLine();
        }
    }
}
