using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    class Worker : Employee
    {
        public override string FullName
        {
            get
            {
                return "(Worker)\t" + base.FullName;
            }
        }
        public double Koeficient { get; set; }
        public Worker(string firstName, string lastName, int age, int salary) 
            :base(firstName, lastName, age, salary)
        {
            Koeficient = 0.3;
        }


        public override int Bonus()
        {
            return (int)(Salary * Koeficient);
        }
    }
}
