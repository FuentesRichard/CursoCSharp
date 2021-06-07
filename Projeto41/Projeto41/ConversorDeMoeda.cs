using System;
using System.Globalization;

namespace Projeto41
{
    class ConversorDeMoeda
    {
        public static double Dolar;

        public static double ValorEmReais(double d)
        {
            return d * Dolar * 106.00 / 100.00;
        }

    }
}
