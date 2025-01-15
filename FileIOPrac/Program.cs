using System.Text.Json;

namespace FileIOPrac
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string filePath = @"C:\Users\kshre\source\repos\FileIOPrac\FileIOPrac\products.json";

            // Create some sample data
            var products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 800.00 },
            new Product { Id = 2, Name = "Phone", Price = 500.00 }
        };

            // Write the data to a JSON file
            await WriteJsonToFileAsync(filePath, products);

            // Read the data back from the JSON file
            var loadedProducts = await ReadJsonFromFileAsync(filePath);

            // Display the data
            foreach (var product in loadedProducts)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
        }

        // Method to write data to a JSON file
        static async Task WriteJsonToFileAsync(string filePath, List<Product> products)
        {
            string json = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(filePath, json);
        }

        // Method to read data from a JSON file
        static async Task<List<Product>> ReadJsonFromFileAsync(string filePath)
        {
            string json = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<List<Product>>(json);
        }
        //static void Main(string[] args)
        //{
        //    //DirCreate.MakeDir();

        //    //DirCreate.ListDir();

        //    //DirCreate.ListSubDir();

        //    //DirCreate.GetProp();

        //    //DirCreate.DeleteDir();


        //    //FileImpl.MakeFile();

        //    //FileImpl.WriteFile();

        //    //FileImpl.ReadFile();

        //    //FileImpl.AppendFile();

        //    //FileImpl.CopyFile();

        //    //FileImpl.Prop();

        //    //FileImpl.DelFile();

        //    //CsvIO.AddCsv();
        //    //CsvIO.ReadCsv();

        //    //CsvIO.WriteJson();
        //    //CsvIO.ReadJson();
        //}
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
