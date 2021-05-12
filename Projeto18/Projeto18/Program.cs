using System;
using System.Globalization;

namespace Projeto18
{
    class Program
    {
        static void Main(string[] args)
        {
         
            double s, r, n, p;
            s = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (s <= 400.0)
            {
                p = 15;
            }
            else if (s <= 800.0)
            {
                p = 12;
            }
            else if (s <= 1200.0)
            {
                p = 10;
            }
            else if (s <= 2000.0)
            {
                p = 7;
            }
            else
            {
                p = 4;
            }

            r = p * s / 100;
            n = s + r;

            Console.WriteLine("Novo salario: " + n.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Reajuste ganho: " + r.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Em percentual: " + p + " %");

        }
    }
}
