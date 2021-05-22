using System;
using System.Globalization;

namespace Projeto29
{
    class Program
    {
        static void Main(string[] args)
        
        {

            int X;

            X = int.Parse(Console.ReadLine());

            if (X >= 1 || X <= 1000)
            {
                for (int i = 1; i <= X; i=i+2)
                {                   
                    Console.WriteLine(i);
                }
            }
        }
    }
}
