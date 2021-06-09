using System;

namespace Projeto46
{
    class Program
    {
        static void Main(string[] args)
        {
            //int s = Calculadora.Sum(new int[] { 2, 4 }); Vira:
            int s = Calculadora.Sum(2, 4);
            Console.WriteLine("Soma:" + s);
        }
    }
}
