using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Reservation
    {
        private Customer customer;
        private List<Ticket> ticket = new List<Ticket>();

        public Customer Customer
        {
            get { return customer; }
            set {customer = value; }
        }
        public List<Ticket> Ticket
        {
            get { return ticket; }
            set { ticket = value; }
        }

        public Reservation(Customer customer)
        {
            this.customer = customer;
        }

        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0;
                foreach(Ticket tickets in ticket)
                {
                    if(Customer.Age >= tickets.MinimunAge)
                    {
                        if (tickets.Discount)
                        {
                            totalPrice += tickets.Price * 0.95m;
                        }
                        else
                        {
                            totalPrice += tickets.Price;
                        }
                    }
                }
                if(Customer.Age >= 60)
                {
                    totalPrice *= 0.9m;
                }
                return totalPrice;
            }
        }
    }
}
