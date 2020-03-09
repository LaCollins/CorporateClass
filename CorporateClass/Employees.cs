using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass
{
    class Employees
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }

        public Employees(string firstName, string lastName, string jobTitle, DateTime startDate)
        {
            FirstName = firstName;
            LastName = lastName;
            JobTitle = jobTitle;
            StartDate = startDate;
        }
    }
}
