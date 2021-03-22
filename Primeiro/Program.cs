using System;
using System.Globalization;

namespace ConsoleAplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com seu nome completo:");
            string fullname = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem sua casa?");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome,idade e altura");
            string[] v = Console.ReadLine().Split(' ');
            string snome = v[0];
            int i = int.Parse(v[1]);
            double a = double.Parse(v[2], CultureInfo.InvariantCulture);

            Console.WriteLine(fullname);
            Console.WriteLine(n1);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(snome);
            Console.WriteLine(i);
            Console.WriteLine(a.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
