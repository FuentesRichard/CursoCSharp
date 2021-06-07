using System;
using System.Globalization;

namespace Projeto43
{
    class Program
    {
        static void Main(string[] args)
        {
    
            ContaBancaria c = new ContaBancaria();
            
            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            
            Console.Write("Havera deposito inicial (s/n)?");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre o valor de deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new ContaBancaria(numero, nome, depositoInicial); 
            }
            else
            {
                c = new ContaBancaria(numero, nome);
            }
            
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c);

            Console.WriteLine();

            Console.Write("Entre um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(saque);
            Console.WriteLine(c);

        }
    }
}
