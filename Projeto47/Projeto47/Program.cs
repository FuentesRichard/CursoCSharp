using System;

namespace Projeto47
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            //Triplo.Triplicar(x); - N funciona pq usa escopo local
            Triplo.Triplicar(ref x);
            Console.WriteLine(x);
        }
    }
}
