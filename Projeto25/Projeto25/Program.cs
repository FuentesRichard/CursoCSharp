using System;

namespace Projeto25
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, alcool, Gasolina, Diesel;
            x = int.Parse(Console.ReadLine());
            alcool = 0;
            Gasolina = 0;
            Diesel = 0;

            while (x != 4)
            {
                while (x < 1 || x > 4)
                {
                    x = int.Parse(Console.ReadLine());
                }
                while (x == 1)
                {
                    alcool = alcool + 1;
                    x = int.Parse(Console.ReadLine());
                }
                while (x == 2)
                {
                    Gasolina = Gasolina + 1;
                    x = int.Parse(Console.ReadLine());
                }
                while (x == 3)
                {
                    Diesel = Diesel + 1;
                    x = int.Parse(Console.ReadLine());
                }
            }
            {
                Console.WriteLine("MUITO OBRIGADO");
                Console.WriteLine("Alcool: " + alcool);
                Console.WriteLine("Gasolina: " + Gasolina);
                Console.WriteLine("Diesel: " + Diesel);
            }
        }
    }
}
