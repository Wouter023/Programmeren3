//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace assignment2
//{
//    internal class Customer
//    {
//        private int id;

//        public int Id { get { return id; } set { id = value; } }
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public string EmailAddress { get; set; }

//        public string FullName { get { return $"{FirstName} {LastName}"; } }

//        public Customer(int id, string firstName, string lastName, string emailAddress)
//        {
//            this.id = id;
//            FirstName = firstName;
//            LastName = lastName;
//            EmailAddress = emailAddress;
//        }

//        public override string ToString()
//        {
//            return $"{FullName} ({EmailAddress})";
//        }
//    }
//}
