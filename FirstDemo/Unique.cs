using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class Unique
    {
        public static object[] Remove(object[] arr) { 
            HashSet<object> set = new HashSet<object>();
            foreach (object item in arr) { 
                set.Add(item);
            }
            return set.ToArray();
        }
    }
}
