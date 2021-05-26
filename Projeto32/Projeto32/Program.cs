using System;

namespace Projeto32
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());

            string[] vet;
            vet = new string[N];

            for (int i = 0; i < N; i++)
            {
                vet[i] = Console.ReadLine();
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(vet[i]);
            }




        }
    }
}
