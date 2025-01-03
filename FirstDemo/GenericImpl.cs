using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class GenericImpl
    {
            public static void swap<T>(ref T a, ref T b)
            {
                T temp = a;
                a = b;
                b = temp;

            }
        }
    }
