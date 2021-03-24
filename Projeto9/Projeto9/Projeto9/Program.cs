using System;
using System.Globalization;

namespace Projeto9
{
    class Program
    {
        static void Main(string[] args)
        {

            double N1, N2, NF;

            N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            NF = double.Parse((N1 + N2).ToString("F2"), CultureInfo.InvariantCulture); 

            Console.WriteLine("NOTA FINAL = " + NF.ToString("F2"), CultureInfo.InvariantCulture);
            if (NF < 60.00)
            {

                Console.WriteLine("REPROVADO");

            }



        }
    }
}
