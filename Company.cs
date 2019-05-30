using System;
using System.Collections.Generic;

namespace classes
{
    public class Company
    {
        // Some read only properties (let's talk about gets, baby)
        public string CompanyName { get; set; }
        public DateTime DateFounded { get; set; }
        public List<Employee> ListOfEmpolyees { get; set; }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string companyName, DateTime dateFounded)
        {
            CompanyName = companyName;
            DateFounded = dateFounded;
        }

        // Create a public property for holding a list of current employees
        private List<Employee> ListOfEmployees = new List<Employee>() 
        { 

        };
        public void addEmployee(Employee employee) {
            ListOfEmployees.Add(employee);
        }
        public void listEmployeeDetails()
        {
            foreach (Employee employee in ListOfEmployees)
            {
                Console.WriteLine($"{employee.firstName} {employee.lastName} works for {CompanyName} as {employee.title} since {employee.hireOnDate} ");
            }
        }
    }
}
