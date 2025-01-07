using System;
using System.IO;

namespace FirstDemo
{
    //Custom exception class
    public class FileOperationException : Exception
    {
        public FileOperationException(string message) : base(message) { }

        public override string ToString()
        {
            return $"FileOperationException: {Message} (Occurred at: {DateTime.Now})";
        }
    }

    internal class CreateF
    {
        public static void files()
        {
            try
            {
                string path = @"C:\csharp\ex\test.txt";
                FileStream file = File.Create(path);
                file.Close(); 

                if (File.Exists(path))
                {
                    Console.WriteLine("File created");
                }
                else
                {
                    throw new FileOperationException("File creation failed.");
                }
            }
            catch (FileOperationException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
            }
        }

        public static void writeF()
        {
            try
            {
                string path = @"C:\csharp\ex\test.txt";

                if (!File.Exists(path))
                {
                    throw new FileOperationException("File does not exist.");
                }

                Console.WriteLine("Enter the text you want in the file:");
                string write = Console.ReadLine();

                File.WriteAllText(path, write);
                Console.WriteLine("Appended text successfully");
            }
            catch (FileOperationException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
            }
        }

        public static void readF()
        {
            try
            {
                string path = @"C:\csharp\ex\test.txt";

                if (!File.Exists(path))
                {
                    throw new FileOperationException("Cannot read file. File does not exist.");
                }

                string read = File.ReadAllText(path);
                Console.WriteLine(read);
            }
            catch (FileOperationException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
            }
        }
    }
}
