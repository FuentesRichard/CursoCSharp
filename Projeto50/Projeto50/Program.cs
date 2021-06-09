using System;

namespace Projeto50
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach - Sintaxe opccional para percorrer coleçoes:
            //Para cada OBJETO 'obj' contido em VECT, FAÇA:
            string[] vect = new string[] { "Maria", "Bob", "Alex" };
            foreach(string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
