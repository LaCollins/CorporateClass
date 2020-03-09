using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass
{
    public class Company
    {
        // Some properties
        public string Name { get; }
        public DateTime CreatedOn { get; }
        //public List<Employees> Employees { get; set; }

        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
        }

        public void CreateEmployee()
        {
            Console.WriteLine("Please enter a first name...");

            var firstName = Console.ReadLine();

            Console.WriteLine("Please enter a last name...");

            var lastName = Console.ReadLine();

            Console.WriteLine("Please enter a job title...");

            var job = Console.ReadLine();

        }



        // Create a private property for holding a collection of current employees

        // Create a method that allows a caller to add an employee

        // Create a method that allows a caller to remove an employee

        // Create a method that allows a caller to retrieve the list of employees

    }
}
