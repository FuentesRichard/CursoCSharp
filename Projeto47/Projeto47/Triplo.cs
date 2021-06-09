using System;


namespace Projeto47
{
    class Triplo
    {
        //public static void Triplicar(int x) - Nao funciona s/ref pq usa escopo local
        public static void Triplicar(ref int x)
        {
            x = x * 3;
        }
    }
}
