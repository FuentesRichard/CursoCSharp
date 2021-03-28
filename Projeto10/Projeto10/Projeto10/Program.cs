using System;
using System.Globalization;

namespace Projeto10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Que horas sao?");
            x = int.Parse(Console.ReadLine());

            if (x < 12) { 
            
                Console.WriteLine("Bom dia!");
            }
            
            else {

                if (x < 18)
                {
                    Console.WriteLine("Boa tarde!");
                }
                else
                {
                    Console.WriteLine("Boa noite!");
                }
            }

            Console.ReadLine();
         

        }
    }
}
