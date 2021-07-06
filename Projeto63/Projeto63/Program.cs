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
            List<Shape> list = new();
            Console.Write("Enter the numbers of shapes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or circle (r/c): ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/ Red): ");
                Color color = Enum.Parse < Color>(Console.ReadLine());
                if (resp == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else if (resp == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine("SHAPE AREAS: ");
            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
