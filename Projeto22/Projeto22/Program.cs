using System;

namespace Projeto22
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int pass;
            pass = int.Parse(Console.ReadLine());
            while (pass != 2002)
            {
                Console.WriteLine("Senha Invalida");
                pass = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");

        }
    }
}
