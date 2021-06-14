using System;
using System.Collections.Generic;

namespace Projeto53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int N = int.Parse(Console.ReadLine());

            List<Funcionario> list = new();

            for (int i = 0; i <= N; i++)
            {
                Console.WriteLine("Emplyoee #" + i + ":");
                Console.Write("Id:");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Salary:");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Funcionario(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            
            Funcionario funcionario = list.Find(x => x.Id == searchId);
            if (funcionario != null)
            {
                Console.Write("Enter de percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                funcionario.SalaryIncrease(percentage);

            }            
        }
    }
}
