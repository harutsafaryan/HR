using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    class Accounting : Accountant
    {
        public override string FullName
        {
            get
            {
                //return "(Accounting)\t" + base.base.FullName;  
                return "(Accounting)\t" + base.FullName;  
            }
        }

        public Accounting(string firstName, string lastName, int age, int salary)
            :base(firstName ,lastName, age, salary)
        {
            Koeficient = base.Koeficient * 0.8;
        }
    }
}
