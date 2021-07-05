using System;
using System.Collections.Generic;
using System.Globalization;
using Projeto61.Entitites;

namespace Projeto61
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();
            Console.WriteLine("Enter the number of empliyees: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                string r = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (r == "y")
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    Employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    Employees.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine("PAYMENTS:");
                foreach (Employee employee in Employees)
            {
                Console.WriteLine(employee.Name + " - $" + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}