using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto52
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Richi");//list.Add - Inserir por padrao
            list.Add("Fue");
            list.Insert(1, "Rufino");//list.Insert - Inserir na posiçao q quero
            list.Insert(0, "Fuinos");
            list.Remove("Fuinos");
            list.RemoveAt(2);//Remove na posiçao 2
            list.RemoveAll(x => x[0] == 'A');//Remove todos que começam com 'A'
            list.RemoveRange(2, 2);//A partir da posiçao 2 eu removo 2 elementos
            ImprimirLista(list);
            Console.WriteLine("-----------------------------");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("listCount: " + list.Count);//Tamaho da Lista

            Console.WriteLine("-----------------------------");

            string s1 = list.Find(Test);//Espera predicado(recebe como argumento alg q faz um teste)/Se verdadeiro retorna
            // Posso substituir Test por lambda - ...=list.Find(x => x[0] == 'F');
            Console.WriteLine("First 'F':" + s1);
            string s2 = list.FindLast(x => x[0] == 'F');
            Console.WriteLine("Last 'F': " + s2);
            int pos1 = list.FindIndex(x => x[0] == 'F');//Encontra a posiçao na lista
            Console.WriteLine("First 'F'" + pos1);
            List<string> list2 = list.FindAll(x => x.Length == 3);//Ponteiro pra list1 q vai trazer TODOS q sao True
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }
            
            Console.WriteLine("-------------------------");

            List<string> list3 = list.Where(x => x.Length == 3).ToList();//Substitui o list.FindAll mas cm namespace System.Linq
            ImprimirLista(list3);

            Console.WriteLine("-----------------------------");

        }
        static void ImprimirLista(List<string> lista)//Se o codigo ta repetindo cria um metodo = abstrair
        {
            foreach(string obj in lista)
            {
                Console.WriteLine(obj);
            }
        }


        //Se usar lambda n precisa do = static bool Test(string s)
        static bool Test(string s)
        {
            return s[0] == 'F';//True se a primeira letra e F
        }
    }

}
