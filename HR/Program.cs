using System;
using System.Collections.Generic;

namespace HR
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Vardan", "Vardanyan", 45, 1000);
            Accountant accountant = new Accountant("Simon", "Simonyan", 35, 1000);
            Worker worker = new Worker("Murad", "Muradyan", 29, 1000);
            Accounting accounting = new Accounting("Hakob", "Hakobyan", 32, 1000);

            List<Employee> employees = new List<Employee>();
            employees.Add(manager);
            employees.Add(accountant);
            employees.Add(worker);
            employees.Add(accounting);

            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"{employees[i].FullName} \tbonus is:" + $" {employees[i].Bonus()}");
            }

            manager.Koeficient = 1.1;
            accountant.Koeficient = 1;
            worker.Koeficient = 0.9;

            Console.WriteLine();
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"{employees[i].FullName} \tbonus is:" + $" {employees[i].Bonus()}");
            }

            Console.ReadKey();
        }
    }
}
