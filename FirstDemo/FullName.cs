using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class FullName
    {
        public static void Full(string[] args)
        {
            string fullName = string.Join(" ", args);
            string[] nameParts = fullName.Split(' ');
            Console.WriteLine($"The full name is: {fullName}");
            Console.WriteLine($"The full name has {nameParts.Length} parts.");

            Console.WriteLine("The parts are:");
            foreach (string part in nameParts)
            {
                Console.WriteLine(part);
            }
        }

    }
}
