using System;

namespace Projeto32
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            while (N > -10 && N < 10)
            {
                if (N < 0)
                {
                    Console.WriteLine("Negativo");
                    N = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Nao Negativo");
                    N = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Ate Mais");
        }
    }
}
