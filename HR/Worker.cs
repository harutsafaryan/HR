using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    class Worker : Employee
    {
        public Worker(string firstName, string lastname, int age, int salary) 
            :base(firstName, lastname, age, salary)
        {

        }
        public override int Bonus()
        {
            return (int)(Salary * 0.3);
        }
        public override string Position()
        {
            return "Worker";
        }
    }
}
