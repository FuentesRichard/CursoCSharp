using System;
using System.Globalization;

namespace Projeto42
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto x = new Produto(nome, preco);
            Produto x1 = new Produto();

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
