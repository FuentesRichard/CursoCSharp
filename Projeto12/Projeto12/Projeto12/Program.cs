using System;
using System.Globalization;

namespace Projeto12
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c;
            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            if (a < b && a < c)
            {
                Console.WriteLine("Menor = " + a);

            }
            else
            {
                if (b < a && b < c)
                {
                    Console.WriteLine("Menor = " + b);
                }
                else
                {
                    Console.WriteLine("Menor = " + c);
                }

            }
        }
    }
}
