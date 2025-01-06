using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class CreateF
    {
        public static void files()
        {
            string path = @"C:\csharp\ex\test.txt";
            FileStream file = File.Create(path);

            if (File.Exists(path))
            {
                Console.WriteLine("File created");
            }
            else
            {
                Console.WriteLine("File not created");
            }
        }

        public static void writeF()
        {
            string path = @"C:\csharp\ex\test.txt";
            Console.WriteLine("Enter the text you want in the file");
            string write = Console.ReadLine();

            File.WriteAllText(path, write);
            Console.WriteLine("Appended text successfully");
        }

        public static void readF() 
        {
            string path = @"C:\csharp\ex\test.txt";
            if (File.Exists(path))
            {
                string read = File.ReadAllText(path);
                Console.WriteLine(read);
            }
            else
            {
                Console.WriteLine("No file present");
            }
        }
    }
}
