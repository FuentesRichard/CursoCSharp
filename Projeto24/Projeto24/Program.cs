using System;

namespace Projeto24
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;
            nota1 = double.Parse(Console.ReadLine());
            nota2 = double.Parse(Console.ReadLine());

            while (nota1 < 0 || nota1 > 10)
            {
                Console.WriteLine("nota invalida");
                nota1 = double.Parse(Console.ReadLine());
            }
            while (nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("nota invalida");
                nota2 = double.Parse(Console.ReadLine());
            }
            media = (nota1 + nota2) / 2;
            Console.WriteLine("media = " + media);
            Console.ReadLine();
        }
    }
}
