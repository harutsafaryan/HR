using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    class Employee
    {
        private Guid _id = Guid.NewGuid();
        private string _firstName;
        private string _lastname;
        private int _age;
        private int _salary;

        public string FullName { get => $"{FirstName}  {Lastname}"; }
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (value.Length > 15)
                {
                    throw new Exception("Invalid FirstName");
                }
                else
                {
                    _firstName = value;
                }
            }
        }
        public string Lastname
        {
            get => _lastname;
            set
            {
                if (value.Length > 15)
                {
                    throw new Exception("Invalid LastName");
                }
                else
                {
                    _lastname = value;
                }
            }
        }
        public int Age
        {
            get => _age;
            set
            {
                if (value < 20 || value > 80)
                {
                    throw new Exception("Invalid age");
                }
                else
                {
                    _age = value;
                }
            }
        }
        public int Salary
        {
            get => _salary;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Invalid salary");
                }
                else
                {
                    _salary = value;
                }
            }
        }

        public Employee(string firstName, string lastname, int age, int salary)
        {
            FirstName = firstName;
            Lastname = lastname;
            Age = age;
            Salary = salary;
        }

        public virtual int Bonus()
        {
            return default;
        }

        public virtual string Position()
        {
            return default;
        }
    }
}
