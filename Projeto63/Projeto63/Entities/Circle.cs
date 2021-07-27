using System;
using System.Globalization;
using Projeto63.Entities;
using Projeto63.Entities.Enums;

namespace Projeto63.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            double pi = 3.14;
            return pi * Math.Pow(Radius, 2);
        }
        public override string ToString()
        {
            return "Circle color = "
                + Color
                + ",  Radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", Area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
