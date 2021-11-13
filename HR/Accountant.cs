using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    class Accountant : Employee
    {
        public double Koeficient { get; set; }
        public Accountant(string firstName, string lastname, int age, int salary)
            :base(firstName, lastname, age, salary)
        {
            Koeficient = 0.5;
        }
        public override int Bonus()
        {
            return (int)(Salary * Koeficient);
        }

        public override string Position()
        {
            return "Accountant";
        }
    }
}
