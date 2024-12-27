using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class Vowel
    {
        public static void IsPresent() {
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine().ToLower();
            bool hasA = s.Contains('a');
            bool hasE = s.Contains('e');
            bool hasP = s.Contains('p');

            if (hasA && hasE && hasP)
            {
                Console.WriteLine("All present");
            }
            else if (hasA || hasE || hasP) {
                Console.WriteLine("one or more present");
            }
            else
            {
                Console.WriteLine("None present");
            }
        }
    }
}
