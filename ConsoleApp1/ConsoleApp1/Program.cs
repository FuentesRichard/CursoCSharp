using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int N;
            N = int.Parse(Console.ReadLine());

            int[] A;
            A = new int[N];

            string[] s = Console.ReadLine().Split(' ');
            for (int i=0; i<N; i++)
            {
                A[i] = int.Parse(s[i]);
            }
            Console.ReadLine();
            
        }
    }
}
