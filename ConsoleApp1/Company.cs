using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Company : IEnumerable<Employee>
    {
        private List<Employee> employees;


        public Company(List<Employee> employees)
        {
            this.employees = employees;
        }

        public Company(params Employee[] employees)
        {
            this.employees = employees.ToList<Employee>();
        }


        public void GiveEverybodyBonus(decimal companyBonus)
        {
            foreach (Employee employee in employees)
            {
                employee.SetBonus(companyBonus);
            }
        }

        public decimal TotalToPay()
        {
            decimal result_total = 0;

            foreach (Employee employee in employees)
            {
                result_total += employee.ToPay();
            }

            return result_total;
        }

        public string NameMaxSalary()
        {
            int index_of_max_salary = 0;

            for (int i = 1; i < employees.Count; i++)
            {
                if (employees[index_of_max_salary].ToPay() < employees[i].ToPay())
                {
                    index_of_max_salary = i;
                }
            }
            return employees[index_of_max_salary].Name;
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            foreach (Employee employee in employees)
            {
                yield return employee;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}

