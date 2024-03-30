using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbeeld1
{
    public class Employee
    {
        public string firstName, lastName;
        public string department;
        public float salary;
        public void IncreaseSalary(float increase)
        {
            salary += increase;
        }

        public Employee()
        {
            firstName = "";
            lastName = "";
        }
        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Employee(string firstName, string lastName, string department)
            :this(firstName, lastName)
        {
            this.department = department;
        }
    }

    
}
