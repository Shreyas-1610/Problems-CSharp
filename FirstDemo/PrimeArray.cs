using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class PrimeArray
    {
        public static bool isPrime(int n)
        {
            if (n < 2) return false;
            for(int i = 2; i * i <=n; i++)
            {
                if(n%i == 0) return false;
            }
            return true;
        }

        public static List<int> getPrime(int[] num)
        {
            List<int> PrimeNo = new List<int>();
            foreach (int n in num)
            {
                if (isPrime(n)) PrimeNo.Add(n);
            }
            return PrimeNo;
        }
    }
}
