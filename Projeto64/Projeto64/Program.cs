using System;
using System.Globalization;
using System.Collections.Generic;
using Projeto64.Entities;

namespace Projeto64
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> list = new();
            Console.Write("Insira o numero de Pagantes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Informacoes do Pagante #{i}:");
                Console.Write("Pessoa Fisica ou Juridica: (f/j): ");
                char r = char.Parse(Console.ReadLine());
                if (r == 'f')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Renda Anual: ");
                    double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Despesas de Saude: ");
                    double saude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(saude, nome, rendaAnual));
                }
                else if (r == 'j')
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Renda Anual: ");
                    double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Numero de Funcionarios: ");
                    int funcionarios = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(nome, rendaAnual, funcionarios));
                }
            }
            Console.WriteLine("Taxas Pagas: ");
            double soma = 0.0;
            foreach (Pessoa p in list)
            {
                Console.WriteLine(p);
                soma = soma + p.Imsposto();
            }
            Console.WriteLine("TAXA TOTAL: " + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
