using DAL;
using Model;

namespace ReservationSystemService
{
    public class CustomerService
    {
        private CustomerDAO customerdb;

        public CustomerService()
        {
            customerdb = new CustomerDAO();
        }

        public List<Customer> GetAll()
        {
            List<Customer> students = customerdb.GetAll();
            return students;
        }

        public Customer GetById(int customerId)
        {
            return customerdb.GetById(customerId);
        }
    }
}