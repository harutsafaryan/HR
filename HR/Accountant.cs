using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    class Accountant : Employee
    {
        public Accountant(string firstName, string lastname, int age, int salary)
            :base(firstName, lastname, age, salary)
        {

        }
        public override int Bonus()
        {
            return (int)(Salary * 0.5);
        }

        public override string Position()
        {
            return "Accountant";
        }
    }
}
