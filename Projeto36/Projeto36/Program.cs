using System;
using System.Globalization;

namespace Projeto36
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto x = new Produto();
            
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            x.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            x.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Produto : " + x);
            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionados: ");
            int qte = int.Parse(Console.ReadLine());
            x.AdicionarProdutos(qte);
            Console.WriteLine("Dados Atualizados : " + x);
            int qtd = int.Parse(Console.ReadLine());
            x.RemoverProdutos(qtd);
            Console.WriteLine("Dados Atualizados : " + x);

        }
    }
}
