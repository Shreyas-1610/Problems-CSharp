using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class Height
    {
        public static void GetCat(int height)
        {
            switch (height)
            {
                case < 150:
                    Console.WriteLine("Dwarf");
                    break;
                case > 160:
                    Console.WriteLine("Tall");
                    break;
                default:
                    Console.WriteLine("Average");
                    break;
            }
        }
    }
}
