using System;
using System.Collections.Generic;

namespace CorporateClass
{
        class Program
    {
        static void Main(string[] args)
        {
            var addEmployee = true;

            Employees john = new Employees("John", "Smith", "Milker", DateTime.Now);

            List<Employees> employeeList = new List<Employees>();


            Console.WriteLine("Welcome to Company Builder 2000");
            Console.WriteLine("Please enter a name for your company...");
            var companyName = Console.ReadLine();

            var myCompany = new Company(companyName, DateTime.Now);

            Console.WriteLine($"{myCompany.Name} was created on {myCompany.CreatedOn}");

            Console.WriteLine("Would you like to add an employee? (Y/N)");

            var answer = Console.ReadLine();

            while (addEmployee)
            {
                if (answer == "Y" || answer == "y")
                {
                    var newEmployee = CreateEmployee();

                    employeeList.Add(newEmployee);

                    Console.WriteLine("Would you like to add another?");

                    answer = Console.ReadLine();
                }
                else
                {
                    addEmployee = false;
                }
            }

            myCompany.employees = employeeList;

            foreach (Employees employee in employeeList)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} is a {employee.JobTitle} at {myCompany.Name}");
            }

            Console.ReadKey();
        }

        static Employees CreateEmployee()
        {
            Console.WriteLine("Please enter a first name...");

            var firstName = Console.ReadLine();

            Console.WriteLine("Please enter a last name...");

            var lastName = Console.ReadLine();

            Console.WriteLine("Please enter a job title...");

            var job = Console.ReadLine();

            Employees newEmployee = new Employees(firstName, lastName, job, DateTime.Now);

            return newEmployee;
        }
    }

}
