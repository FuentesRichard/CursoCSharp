using System;
using System.Globalization;

namespace Projeto5
{
    class Program
    {
        static void Main(string[] args)
        {

            String Nome;
            double SalarioFixo, Montante, Total;

            Nome = Console.ReadLine();
            SalarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Montante = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Total = (double)SalarioFixo + 15 * Montante / 100;
            
            Console.WriteLine("TOTAL = R$ " + Total.ToString("F2"), CultureInfo.InvariantCulture);


        }
    }
}
