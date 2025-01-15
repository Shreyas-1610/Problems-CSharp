using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOPrac
{
    internal class FileImpl
    {
        public static void MakeFile()
        {
            string path = @"C:\Users\kshre\source\repos\FileIOPrac\FileIOPrac\example.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Already exists.");
                return;
            }
            else
            {
                File.Create(path);
                Console.WriteLine("File created");
            }
        }

        public static void WriteFile()
        {
            string path = @"C:\Users\kshre\source\repos\FileIOPrac\FileIOPrac\example.txt";
            string content = "Hello world";
            File.WriteAllText(path, content);
            Console.WriteLine("Written in file");
        }

        public static void ReadFile()
        {
            string path = @"C:\Users\kshre\source\repos\FileIOPrac\FileIOPrac\example.txt";
            string read = File.ReadAllText(path);
            Console.WriteLine("File content: ");
            Console.WriteLine(read);
        }

        public static void AppendFile()
        {
            string path = @"C:\Users\kshre\source\repos\FileIOPrac\FileIOPrac\example.txt";
            string appendText = "Appended text";
            File.AppendAllText(path, appendText);
            Console.WriteLine("Appended text");
        }

        public static void CopyFile()
        {
            string source = @"C:\Users\kshre\source\repos\FileIOPrac\FileIOPrac\example.txt";
            string dest = @"C:\Users\kshre\source\repos\FileIOPrac\FileIOPrac\exampleCopy.txt";
            if (File.Exists(source))
            {
                File.Copy(source,dest,overwrite:true);
                Console.WriteLine("Copied successfully");
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }

        public static void Prop()
        {
            string path = @"C:\Users\kshre\source\repos\FileIOPrac\FileIOPrac\example.txt";
            FileInfo Info = new FileInfo(path);

            if (Info.Exists)
            {
                Console.WriteLine($"File Name: {Info.Name}");
                Console.WriteLine($"File Size: {Info.Length} bytes");
                Console.WriteLine($"Creation Time: {Info.CreationTime}");
                Console.WriteLine($"Last Access Time: {Info.LastAccessTime}");
                Console.WriteLine($"Last Write Time: {Info.LastWriteTime}");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }

        public static void DelFile()
        {
            string path = @"C:\Users\kshre\source\repos\FileIOPrac\FileIOPrac\example.txt";
            if (!File.Exists(path))
            {
                Console.WriteLine("File doesnt exist");
            }
            else
            {
                File.Delete(path);
                Console.WriteLine("File deleted");
            }
        }
    }
}
