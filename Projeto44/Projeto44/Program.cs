using System;
using System.Globalization;

namespace Projeto44
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product[] vect = new Product[n];
            for (int i = 0; i < n; i++)
            {
                vect[i].Name = Console.ReadLine();
                vect[i].Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }
            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE : " + avg.ToString("F2", CultureInfo.InvariantCulture));


        }

    }

}
