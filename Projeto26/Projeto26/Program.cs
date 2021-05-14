using System;
using System.Globalization;

namespace Projeto26
{
    class Program
    {
        static void Main(string[] args)
        {
            double i, soma, quant, media;
            i = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            soma = 0;
            quant = 0;
            
            while (i > 0)
            {
                soma = soma + i;
                quant = quant + 1;
                i = double.Parse(Console.ReadLine());
            }

            media = soma / quant;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
