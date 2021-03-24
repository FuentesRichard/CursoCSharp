using System;
using System.Globalization;

namespace Projeto4
{
    class Program
    {
        static void Main(string[] args)
        {

            String N1, N2;
            int I1, I2;
            double M;

            String[] V;

            V = Console.ReadLine().Split(' ');
            N1 = V[0];
            I1 = int.Parse(V[1]);

            V = Console.ReadLine().Split(' ');
            N2 = V[0];
            I2 = int.Parse(V[1]);

            M = (I1 + I2) / 2;

            Console.WriteLine("A idade média de " + N1 + " e " + N2 + " é de " + M + " anos");

        }
    }
}
