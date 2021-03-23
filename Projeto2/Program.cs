using System;
using System.Globalization;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {

            double largura, comprimento, preçoMQ, area, preço;
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            preçoMQ = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            preço = area * preçoMQ;

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + preço.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
