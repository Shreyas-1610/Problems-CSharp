using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOPrac
{
    internal class DirCreate
    {
        public static void MakeDir()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\kshre\source\repos\FileIOPrac\FileIOPrac\Example");
            try
            {
                if (directory.Exists)
                {
                    Console.WriteLine("Directory already exists.");
                    return;
                }
                directory.Create();
                Console.WriteLine("Directory created.");
            }
            catch(Exception e) 
            {
                Console.WriteLine("Not created:{0}",e.ToString());
            }
        }
        //list files in directories
        public static void ListDir()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\kshre\source\repos\FileIOPrac\FileIOPrac");

            if (dir.Exists)
            {
                FileInfo[] files = dir.GetFiles();

                foreach (FileInfo file in files)
                {
                    Console.WriteLine($"File Name: {file.Name}, Size: {file.Length} bytes");
                }
            }
            else
            {
                Console.WriteLine("Directory does not exist.");
            }
        }
        //list subdirectiors in main dir
        public static void ListSubDir()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\kshre\source\repos\FileIOPrac\FileIOPrac");

            if (dir.Exists)
            {
                DirectoryInfo[] Dirs = dir.GetDirectories();

                foreach (DirectoryInfo subDir in Dirs)
                {
                    Console.WriteLine($"Subdirectory Name: {subDir.Name}");
                }
            }
            else
            {
                Console.WriteLine("Directory does not exist.");
            }
        }

        //get properties
        public static void GetProp()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\kshre\source\repos\FileIOPrac");

            if (dir.Exists)
            {
                Console.WriteLine($"Full Name: {dir.FullName}");
                Console.WriteLine($"Name: {dir.Name}");
                Console.WriteLine($"Parent: {dir.Parent}");
                Console.WriteLine($"Creation Time: {dir.CreationTime}");
                Console.WriteLine($"Last Access: {dir.LastAccessTime}");
                Console.WriteLine($"Last Write: {dir.LastWriteTime}");
            }
            else
            {
                Console.WriteLine("Directory does not exist.");
            }
        }

        //delete dir
        public static void DeleteDir()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\kshre\source\repos\FileIOPrac\FileIOPrac\Example");

            if (dir.Exists)
            {
                dir.Delete(true); 
                Console.WriteLine("Directory deleted successfully.");
            }
            else
            {
                Console.WriteLine("Directory does not exist.");
            }
        }
    }
}
