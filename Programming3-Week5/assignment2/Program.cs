using DAL;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Model;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            CustomerDAO customerDAO = new CustomerDAO();

            // display all customers

            List<Customer> customers = customerDAO.GetAll();
            foreach (Customer cust in customers)
            {
                Console.WriteLine(cust);
            }

            //Console.WriteLine($"{Customer customer = customerDAO.GetById(1)}");
            BookDAO bookDAO = new BookDAO();    
            List<Book> books = bookDAO.GetAll();
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }

        }
    }
}
