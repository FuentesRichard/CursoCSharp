using System;
using System.Globalization;

namespace Projeto37
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo R = new Retangulo();
            
            Console.WriteLine("Entre a largura e altura do retangulo:");
            R.Largura = double.Parse(Console.ReadLine());
            R.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("AREA = " + R.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + R.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + R.Diagonal().ToString("F2",CultureInfo.InvariantCulture));
            
        }
    }
}
