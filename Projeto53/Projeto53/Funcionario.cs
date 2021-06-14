using System;
using System.Collections.Generic;
using System.Globalization;

namespace Projeto53
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }


        public Funcionario()
        {
        }

        public Funcionario(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

   
        public void SalaryIncrease(double aumento)
        {
            Salary += (aumento / 100.00 * Salary);
        }
        public override string ToString()
        {
            return Id
         + ", "
         + Name
         + ", "
         + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
