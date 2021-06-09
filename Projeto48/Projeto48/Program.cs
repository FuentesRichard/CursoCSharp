
using System;

namespace Projeto48
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); 
            int triple;
            Calculator.Triple(a, out triple);
            //a=variavel de origem / out triple onde guardei o resultado
            Console.WriteLine(triple);
            //imprimi a variavel onde guardei o resultado
            //Diferença REF X OUT:
            //REF tem q iniciar e OUT Nao
            //REF e OUT sao Code Smells(Desing Ruim)
        }
    }
}
