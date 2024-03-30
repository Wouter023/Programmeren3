//using System;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace assignment2
//{
//    class CustomerDAO
//    {
//        private SqlConnection dbConnection;

//        public CustomerDAO()
//        {
//            string connString = ConfigurationManager.
//                ConnectionStrings["DBConnectionString"].ConnectionString;
//            dbConnection = new SqlConnection(connString);
//        }

//        public List<Customer> GetAll()
//        {
//            dbConnection.Open();
//            SqlCommand command = new SqlCommand("SELECT * FROM Customers", dbConnection);
//            SqlDataReader reader = command.ExecuteReader();
//            List<Customer> customers = new List<Customer>();
//            while (reader.Read())
//            {
//                Customer customer = ReadCustomer(reader);
//                customers.Add(customer);
//            }
//            reader.Close();
//            dbConnection.Close();

//            return customers;
//        }

//        private Customer ReadCustomer(SqlDataReader reader)
//        {
//            int id = (int)reader["id"];
//            string firstName = (string)reader["FirstName"];
//            string lastName = (string)reader["LastName"];
//            string emailAdress = (string)reader["EmailAddress"];

//            return new Customer(id, firstName, lastName, emailAdress);
//        }

//        public Customer GetById(int customerId)
//        {
//            dbConnection.Open();
//            SqlCommand command = new SqlCommand("SELECT * FROM Customers WHERE Id = @Id", dbConnection);
//            command.Parameters.AddWithValue("@Id", customerId);

//            SqlDataReader reader = command.ExecuteReader();
//            Customer customer = null;
//            if (reader.Read())
//            {
//                customer = ReadCustomer(reader);
//            }
//            reader.Close();
//            dbConnection.Close();

//            return customer;
//        }
//    }
//}
