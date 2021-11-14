using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    class Manager : Employee
    {
        public override string FullName
        {
            get
            {
                return "(Manager)\t" + base.FullName;
            }
        }
        public double Koeficient { get; set; }
        public Manager(string firstName, string lastName, int age, int salary)
            :base(firstName, lastName, age, salary)
        {
            Koeficient = 0.8;
        }
        public override int Bonus()
        {
            return (int)(Salary * Koeficient);
        }
    }
}
