using System;
using System.Globalization;
using System.Collections.Generic;
using Projeto62.Entities;

namespace Projeto62
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> List = new();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                string r = Console.ReadLine();
                if (r == "c")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    List.Add(new Product(name, price));
                }
                else if (r == "u")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    List.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (r == "i")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    List.Add(new ImportedProduct(name, price, customFee));
                }
            }
            Console.WriteLine("PRICE TAGS:");
            foreach(Product p in List)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
