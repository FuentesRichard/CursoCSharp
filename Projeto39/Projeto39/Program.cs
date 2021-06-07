using System;
using System.Globalization;

namespace Projeto39
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Circunferencia: " + Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + Volume(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        static double Volume(double r)
        {
            return 4.0 * Pi * Math.Pow(r, 3) / 3.0;
        }
    }
}
