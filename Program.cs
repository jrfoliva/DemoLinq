using System;
using System.Linq;
using DemoLinq.Entities;
using System.Collections.Generic;

namespace DemoLinq
{
    internal class Program
    {

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>();
            products.Add(new Product(1, "Computer", 1100.0, c2));
            products.Add(new Product(2, "Hammer", 90.0, c1));
            products.Add(new Product(3, "TV", 1700.0, c3));
            products.Add(new Product(4, "Notebook", 1300.0, c2));
            products.Add(new Product(5, "Saw", 80.0, c1));
            products.Add(new Product(6, "Tablet", 700.0, c2));
            products.Add(new Product(7, "Camera", 700.0, c3));
            products.Add(new Product(8, "Printer", 350.0, c2));
            products.Add(new Product(9, "MacBook", 1800.0, c2));
            products.Add(new Product(10,"Sound Bar", 700.0, c3));
            products.Add(new Product(11,"Level", 70.0, c1));

            var result1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("Show Tier 1 and Price < 900.00", result1);


        }
    }
}