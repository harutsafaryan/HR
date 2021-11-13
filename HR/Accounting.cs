using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    class Accounting : Accountant
    {
        public Accounting(string firstName, string lastName, int age, int salary)
            :base(firstName ,lastName, age, salary)
        {
            Koeficient = base.Koeficient * 0.8;
        }

        public override string Position()
        {
            return "Accounting";
        }
    }
}
