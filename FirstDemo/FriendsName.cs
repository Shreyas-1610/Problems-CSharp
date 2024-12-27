using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class FriendsName
    {
        public static void Friends()
        {
            int n = 5;
            string[] str = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Type your {i} Friend's name: ");
                string s= Console.ReadLine();
                str[i] = s;
            }
            Console.WriteLine("Friend names are: ");
            foreach (string s in str) {
                Console.Write(s+" ");
            }
        }
    }
}
