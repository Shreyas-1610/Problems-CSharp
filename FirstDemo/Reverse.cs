using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class Reverse
    {
        public static string Words(string str)
        {
            string[] words = str.Split(" ");
            StringBuilder sb = new StringBuilder();
            for (int i = words.Length - 1; i >= 0; i--) {
                sb.Append(words[i]);
                if (i != 0)
                {
                    sb.Append(" ");
                }
            }
            return sb.ToString();
        }
    }
}
