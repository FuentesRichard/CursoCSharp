using System;
using System.Globalization;

namespace Projeto38
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario F = new Funcionario();

            Console.Write("Nome: ");
            F.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            F.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            F.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + F);

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double p = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            F.AumentarSalario(p).ToString("F2", CultureInfo.InvariantCulture);

            Console.WriteLine("Dados atualizados: " + F);
        }
    }
}
