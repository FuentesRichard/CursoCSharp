using System;

namespace Projeto8
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, a1, a2, a5, a10, a20, a50, a100, r1, r2, r5, r10, r20, r50, r100;
            N = int.Parse(Console.ReadLine());

            a100 = N / 100;
            r100 = N % 100;

            a50 = r100 / 50;
            r50 = r100 % 50;

            a20 = r50 / 20;
            r20 = r50 % 20;

            a10 = r20 / 10;
            r10 = r20 % 10;

            a5 = r10 / 5;
            r5 = r10 % 5;

            a2 = r5 / 2;
            r2 = r5 % 2;

            a1 = r2 / 1;
            r1 = r2 % 1;

            Console.WriteLine(N);
            Console.WriteLine(a100 + " nota(s) de R$ 100,00");
            Console.WriteLine(a50 + " nota(s) de R$ 50,00");
            Console.WriteLine(a20 + " nota(s) de R$ 20,00");
            Console.WriteLine(a10 + " nota(s) de R$ 10,00");
            Console.WriteLine(a5 + " nota(s) de R$ 5,00");
            Console.WriteLine(a2 + " nota(s) de R$ 2,00");
            Console.WriteLine(a1 + " nota(s) de R$ 1,00");

        }
    }
}
