using System;
using System.Globalization;

namespace Projeto33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triangulo X:");

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y:");

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p1 = (x.A + x.B + x.C) / 2.0;
            double p2 = (y.A + y.B + y.C) / 2.0;
            double areax = Math.Sqrt(p1 * (p1 - x.A) * (p1 - x.B) * (p1 - x.C));
            double  areay = Math.Sqrt(p2 * (p2 - y.A) * (p2 - y.B) * (p2 - y.C));

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
