using System;

namespace Projeto27
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(5 * x + 20);
                    x = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine(x = 5 * x + 25);
                    x = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
