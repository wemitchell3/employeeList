using System;
using System.Collections.Generic;

namespace classes
{
    public class Employee
    {
        // Some read only properties (let's talk about gets, baby)
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string title { get; set; }
        public DateTime hireOnDate { get; set; }

        // Constructor
        public Employee()
        {
            firstName = firstName;
            lastName = lastName;
            title = title;
            hireOnDate = hireOnDate;
        }
    }
}
