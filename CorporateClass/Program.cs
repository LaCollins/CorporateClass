using System;

namespace CorporateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Company Builder 2000");
            Console.WriteLine("Please enter a name for your company...");

            var companyName = Console.ReadLine();

            var myCompany = new Company(companyName, DateTime.Now);

            Console.WriteLine($"{myCompany.Name} was created on {myCompany.CreatedOn}");

            Console.WriteLine("Would you like to add an employee? (Y/N)");
            
            var answer = Console.ReadKey();

            if (answer.KeyChar == 'Y' || answer.KeyChar == 'y')
            {
                myCompany.CreateEmployee();
            }
            
            Console.ReadKey();
        }
    }
}
