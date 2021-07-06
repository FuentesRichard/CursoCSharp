using System;
using System.Globalization;
using Projeto63.Entities;
using Projeto63.Entities.Enums;

namespace Projeto63.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {

        }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            double pi = 3.14;
            return pi * Math.Pow(Radius, 2);
        }
    }
}
