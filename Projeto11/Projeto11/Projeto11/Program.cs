using System;
using System.Globalization;

namespace Projeto11
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, x1, x2, Delta;

            string[] vet;
            vet = Console.ReadLine().Split(" ");
         
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Delta = Math.Pow(B, 2.0) - 4 * A * C;
            x1 = (-(B) + Math.Sqrt(Delta)) / (2.0 * A);
            x2 = (-(B) - Math.Sqrt(Delta)) / (2.0 * A);

            if (A == 0 || Delta < 0.0) {

                Console.WriteLine("Impossivel Calcular");
            
            }

            else {

                Console.WriteLine("R1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));

            }



        }
    }
}
