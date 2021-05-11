using System;

namespace Projeto17
{
    class Program
    {
        static void Main(string[] args)
        {

            int I, F, R;
            String[] Horas = Console.ReadLine().Split(' ');
            I = int.Parse(Horas[0]);
            F = int.Parse(Horas[1]);

            if (F > I)
            {
                R = F - I;
                Console.WriteLine("O JOGO DUROU " + R + " HORA(S)");
            }
            else if (I > F)
            {
                R = 24 - (I - F);
                Console.WriteLine("O JOGO DUROU " + R + " HORA(S)");
            }
            else if (I == F)
            {
                R = 24;
                Console.WriteLine("O JOGO DUROU " + R + " HORA(S)");
            }
        }
    }
}
