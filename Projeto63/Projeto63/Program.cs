using System;
using System.Globalization;
using System.Collections.Generic;
using Projeto63.Entities;
using Projeto63.Entities.Enums;

namespace Projeto63
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.Black };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Blue };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            //Herdar = Reuzo
            //Interface = Contrato a ser cumprido
        }
    }
}
