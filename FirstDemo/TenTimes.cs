using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class TenTimes
    {
        public static string MultTen(string s)
        {
            int num = int.Parse(s);
            string tenTimes = (num*10).ToString();
            return tenTimes;
        }
    }
}
