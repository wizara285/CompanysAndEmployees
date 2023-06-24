using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Employee
    {
        private readonly string name;
        private decimal salary;
        private decimal bonus;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value >= 0)
                    salary = value;
            }
        }

        public decimal Bonus
        {
            get
            {
                return bonus;
            }
        }

        public Employee(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public virtual void SetBonus(decimal bonus)
        {
            this.bonus = bonus;
        }

        public decimal ToPay()
        {
            return bonus + salary;
        }
    }
}

