using System;
using Projeto63.Entities.Enums;

namespace Projeto63.Entities
{
    abstract class AbstractShape : IShape
    {

        public Color Color { get; set; }

        public abstract double Area();
    }
}
