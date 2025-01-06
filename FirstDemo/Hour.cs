using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class Hour
    {
        public static void ConvertToS(int hour)
        {
            float mins = 0;
            float secs = 0;

            mins = hour * 60;
            secs = hour * 3600;

            Console.WriteLine($"{hour} hour/s in mins is: {mins} minutes \n{hour} hour/s in seconds are: {secs} seconds");
        }
    }
}
