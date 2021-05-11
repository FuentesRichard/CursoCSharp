using System;
using System.Globalization;

namespace Projeto15
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            double preco;
            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            switch(x)
            {
                case 1:
                    preco = 4.00;
                    Console.WriteLine("Total: R$ " + (preco * y/1.0).ToString("F2",CultureInfo.InvariantCulture));
                    break;
                case 2:
                    preco = 4.50;
                    Console.WriteLine("Total: R$ " + (preco * y / 1.0).ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    preco = 5.00;
                    Console.WriteLine("Total: R$ " + (preco * y / 1.0).ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    preco = 2.00;
                    Console.WriteLine("Total: R$ " + (preco * y / 1.0).ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 5:
                    preco = 1.50;
                    Console.WriteLine("Total: R$ " + (preco * y / 1.0).ToString("F2", CultureInfo.InvariantCulture));
                    break;
            }


          
        }
    }
}
