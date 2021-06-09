using System;

namespace Projeto49
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boxing = objeto tipo valor em tipo referenia
            int x = 20;
            object obj = x;
            //unboxing = objeto tipo referencia em tipo valor
            int y = (int)obj; //precisa do casting 
        }
    }
}
