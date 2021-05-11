using System;
using System.Globalization;

namespace Projeto11
{
    class Program
    {
        static void Main(string[] args)
        {

            double A, B, C, X1, X2, Delta;
            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet [0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Delta = Math.Pow(B, 2.0) - (4 * A * C);
            X1 = (-(B) + Math.Sqrt(Delta)) / (2.0 * A);
            X2 = (-(B) - Math.Sqrt(Delta)) / (2.0 * A);
            

            if (Delta < 0 || A == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                Console.WriteLine("R1 = " + X1.ToString("F5",CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + X2.ToString("F5",CultureInfo.InvariantCulture));
            }

        }
    }
}
