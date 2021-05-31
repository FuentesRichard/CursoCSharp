using System;
using System.Globalization;

namespace Projeto33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triangulo X:");

            double l1, l2, l3, a1, a2, a3, areax, areay;

            l1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            l2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            l3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo X:");

            a1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p1 = (l1 + l2 + l3) / 2.0;
            double p2 = (a1 + a2 + a3) / 2.0;
            areax = Math.Sqrt(p1 * (p1 - l1) * (p1 - l2) * (p1 - l3));
            areay = Math.Sqrt(p2 * (p2 - a1) * (p2 - a2) * (p2 - a3));

            Console.WriteLine("Area de X = " + areax.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("Area de Y = " + areay.ToString("F4"), CultureInfo.InvariantCulture);
            if (areax > areay)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }

        }

    }
}
