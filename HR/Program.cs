using System;
using System.Collections.Generic;

namespace HR
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Vardan", "Vardanyan", 45, 800);
            Accountant accountant = new Accountant("Simon", "Simonyan", 35, 700);
            Worker worker = new Worker("Murad", "Muradyan", 29, 650);

            List<Employee> employees = new List<Employee>();
            employees.Add(manager);
            employees.Add(accountant);
            employees.Add(worker);

            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"({employees[i].Position()}) { employees[i].FullName} bonus is:" +
                    $" {employees[i].Bonus()}");
            }

            Console.ReadKey();
        }
    }
}
