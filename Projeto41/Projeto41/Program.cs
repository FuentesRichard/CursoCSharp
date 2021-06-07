using System;
using System.Globalization;

namespace Projeto41
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Qual e a cotaçao do dolar? ");
            ConversorDeMoeda.Dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares voce vai comprar? ");
            double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double reais = ConversorDeMoeda.ValorEmReais(dolares);
            Console.WriteLine("Valor a ser pago em reais = " + reais.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
