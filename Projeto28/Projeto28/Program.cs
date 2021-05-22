using System;

namespace Projeto28
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, i;
            N = int.Parse(Console.ReadLine());
            if (N > 2 || N < 1000)
            {
                for (i = 1; i <= 10; i++)
                {
                    Console.WriteLine(N + " x " + i + " = " + (N * i));
                }
            }
        }
    }
}
