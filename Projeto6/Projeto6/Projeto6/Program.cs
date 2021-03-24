using System;
using System.Globalization;

namespace Projeto6
{
    class Program
    {
        static void Main(string[] args)
        {

            double R, pi, Volume;
            pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Volume = (double)(4 / 3.0) * pi * Math.Pow(R, 3);

            Console.WriteLine("VOLUME = " + Volume.ToString("F3"), CultureInfo.InvariantCulture);

        }
    }
}
