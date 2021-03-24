using System;
using System.Globalization;

namespace Projeto3
{
    class Program
    {
        static void Main(string[] args)
        {

            double B, h, A, P, D;
            B = double.Parse(Console.ReadLine());
            h = double.Parse(Console.ReadLine());

            A = (double)B * h;
            P = (double)2 * (B + h);
            D = Math.Sqrt((double)B * B + h * h);

            Console.WriteLine("AREA =" + A.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("PERIMETRO =" + P.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("DIAGONAL =" + D.ToString("F4"), CultureInfo.InvariantCulture);

        }
    }
}
