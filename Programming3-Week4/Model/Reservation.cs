using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reservation
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }
        public Customer Customer { get; set; }
        public Book Book { get; set; }

        public DateTime ReservatieDateTime;
        public Reservation(int id, Customer customer, Book book) { 
            this.Id = id;
            this.Customer = customer;
            this.Book = book;
        }

        public override string ToString()
        {
            return $"{Customer.FullName} ({Customer.EmailAddress}) -> '{Book.Title}' by {Book.Author}"; 
        }
    }
}
