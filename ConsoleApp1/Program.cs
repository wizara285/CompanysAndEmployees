using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Net.Mail;
using System.Net;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            SalesPerson salesPerson = new SalesPerson("SalesPerson", 1000, 120);
            Manager manager = new Manager("Manager", 2000, 150);


            salesPerson.SetBonus(300);
            manager.SetBonus(500);


            Console.WriteLine(salesPerson.ToPay()); // 1600
            Console.WriteLine(manager.ToPay()); // 3500


            var companyStuff = new Employee[] { salesPerson, manager };

            var company_1 = new Company(companyStuff);
            var company_2 = new Company(salesPerson, manager);


            foreach (var emploee in company_1)
            {
                Console.WriteLine($"{emploee.Name}: {emploee.Salary}, {emploee.Bonus}");
            }

            foreach (var emploee in company_2)
            {
                Console.WriteLine($"{emploee.Name}: {emploee.Salary}, {emploee.Bonus}");
            }
        }
    }
}







