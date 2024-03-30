using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Customer
    {
        private string name;
        private DateTime dateOfBirth;

        public string Name
        {
            get { return name; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("name cannot be an empty string");
                }
                name = value;
            }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set {
                if(value > DateTime.Today)
                {
                    throw new Exception("date of birth must be in the past");
                }
                dateOfBirth = value;
            }
        }

        public Customer(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public int Age
        {
            get { return (int) ((DateTime.Today - dateOfBirth).TotalDays/365); }
        }

        public bool Discount
        {
            get {
                if (Age >= 60)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
