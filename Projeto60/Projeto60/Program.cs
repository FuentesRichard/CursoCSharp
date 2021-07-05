using System;
using System.Globalization;
using Projeto60.Entitites;
using Projeto60.Entitites.Enums;

namespace Projeto60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date(DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);
            
            Console.WriteLine("Enter the order data:");
            DateTime moment = DateTime.Now;
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(moment, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, price);
                OrderItem item = new OrderItem(quantity, price, product); 
                order.AddItem(item);
            }
            Console.WriteLine("ORDER SUMMARY:");
            Console.Write(order);
        }

    }
}
