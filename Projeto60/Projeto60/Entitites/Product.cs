using System;
using System.Globalization;

namespace Projeto60.Entitites
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return Name
                + ", $"
                + Price;
        }
    }
}
