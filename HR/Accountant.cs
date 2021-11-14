using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    class Accountant : Employee
    {
        public override string FullName 
        {
            get
            {
                return "(Accountant)\t" + base.FullName;
            }
        }
        public double Koeficient { get; set; }
        public Accountant(string firstName, string lastName, int age, int salary)
            :base(firstName, lastName, age, salary)
        {
            Koeficient = 0.5;
        }
        public override int Bonus()
        {
            return (int)(Salary * Koeficient);
        }
    }
}
