using System;

namespace Projeto7
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, horas, minutos, segundos, resto;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            resto = N % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

        }
    }
}
