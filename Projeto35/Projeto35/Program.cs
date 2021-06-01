using System;
using System.Globalization;

namespace Projeto35
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario p1 = new Funcionario();
            Funcionario p2 = new Funcionario();
            
            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Dados do segundo funcionario: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (p1.Salario + p2.Salario) / 2.0;
            Console.WriteLine("Salario medio = " + media.ToString("F2"),CultureInfo.InvariantCulture);
        }
    }
}
