using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main()
        {
            // Create an instance of a company. Name it whatever you like.
            Company practice = new Company("Practice, Inc.", new DateTime(2019, 5, 30));

            // Create three employees
            Employee billy = new Employee()
            {
                firstName = "Billy",
                lastName = "Mitchell",
                title = "Junior Developer",
                hireOnDate = new DateTime(2019, 5, 30)
            };

            Employee rose = new Employee()
            {
                firstName = "Rose",
                lastName = "Wisotzky",
                title = "Junior Developer",
                hireOnDate = new DateTime(2019, 5, 30)
            };

            Employee chris = new Employee()
            {
                firstName = "Chris",
                lastName = "Morgan",
                title = "Junior Developer",
                hireOnDate = new DateTime(2019, 5, 30)
            };

            // Assign the employees to the company
            practice.addEmployee(billy);
            practice.addEmployee(rose);
            practice.addEmployee(chris);
            practice.listEmployeeDetails();
        }
    }
}