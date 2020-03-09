using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass
{
    class Employees
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string JobTitle { get; private set; }
        public DateTime StartDate { get; private set; }

        public Employees(string firstName, string lastName, string jobTitle, DateTime startDate)
        {
            FirstName = firstName;
            LastName = lastName;
            JobTitle = jobTitle;
            StartDate = startDate;
        }
    }
}
