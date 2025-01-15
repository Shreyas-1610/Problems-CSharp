using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOPrac
{
    internal class CsvIO
    {
        public static void AddCsv()
        {
            string path = @"C:\Users\kshre\source\repos\FileIOPrac\FileIOPrac\example.csv";
            //File.Create(path);
            Console.WriteLine("Created");
            var records = new List<User>
            {
                new User{Id = 1, Name = "Shreyas", Email = "shreyas@gmail.com"},
                new User{Id = 2, Name = "DEF", Email = "abc@gmail.com"},
                new User{Id = 3, Name = "BCC", Email = "def@gmail.com"},
                new User{Id = 4, Name = "A", Email = "ghi@gmail.com"},
                new User{Id = 5, Name = "ABC", Email = "klm@gmail.com"}
            };

            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }
            Console.WriteLine("DATA WRITTEN");
        }

        public static void ReadCsv()
        {
            string path = @"C:\Users\kshre\source\repos\FileIOPrac\FileIOPrac\example.csv";
            using (var reader = new StreamReader(path))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var dataCsv = csvReader.GetRecords<User>();
                foreach(var data in dataCsv)
                {
                    Console.WriteLine($"ID:{data.Id}, Name:{data.Name}, Email:{data.Email}");
                }
            }
        }

        public static void WriteJson()
        {
            string path = @"C:\Users\kshre\source\repos\FileIOPrac\FileIOPrac\example1.json";
            //File.Create(path);
            Console.WriteLine("Created");
            var records = new List<User>
            {
                new User{Id = 1, Name = "Shreyas", Email = "shreyas@gmail.com"},
                new User{Id = 2, Name = "DEF", Email = "abc@gmail.com"},
                new User{Id = 3, Name = "BCC", Email = "def@gmail.com"},
                new User{Id = 4, Name = "A", Email = "ghi@gmail.com"},
                new User{Id = 5, Name = "ABC", Email = "klm@gmail.com"}
            };
            string json = JsonConvert.SerializeObject(records, Formatting.Indented);
            File.WriteAllText(path, json);
            Console.WriteLine("Data Added");
        }

        public static void ReadJson()
        {
            string path = @"C:\Users\kshre\source\repos\FileIOPrac\FileIOPrac\example1.json";
            string json = File.ReadAllText(path);
            var deserialize = JsonConvert.DeserializeObject<List<User>>(json);
            foreach(var data in deserialize)
            {
                Console.WriteLine($"ID:{data.Id}, Name:{data.Name}, Email:{data.Email}");
            }
        }
    }
}
