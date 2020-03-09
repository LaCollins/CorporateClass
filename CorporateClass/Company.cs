using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass
{
    class Company
    {
        // Some properties
        public string Name { get; }
        public DateTime CreatedOn { get; }
        public List<Employees> employees { get; set; }

        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
        }



        //Create a private property for holding a collection of current employees

        // Create a method that allows a caller to add an employee

        // Create a method that allows a caller to remove an employee

        // Create a method that allows a caller to retrieve the list of employees

    }
}
