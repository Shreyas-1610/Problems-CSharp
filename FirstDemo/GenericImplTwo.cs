using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    public class GenericImplTwo<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item) { 
            items.Add(item);
            Console.WriteLine($"Added: {item}");
        }

        public void Display()
        {
            Console.WriteLine("Contents: ");
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
