using System;

namespace Projeto54
{
    class Program
    {
        static void Main(string[] args)
        {
            //Homogenea/Ordenada/AlocadaDe1SoVez
            //Vantagem:AcessoImediatoPelasPosicoes
            //Desvantagem:TamanhoFixo/DificilInsercaoDelecao

            int[,] mat = new int[2, 3];
            Console.WriteLine(mat.Length);//NDeElementos
            Console.WriteLine(mat.Rank);//QuantidadeLinhas
            Console.WriteLine(mat.GetLength(0));//QuantidadeNaDimensao'0'=>2Linhas
            Console.WriteLine(mat.GetLength(1));//QuantidadeNaDomensao'1'=>3Colunas

            
        }
    }
}
