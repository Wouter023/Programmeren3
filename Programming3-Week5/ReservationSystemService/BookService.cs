using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationSystemService
{
    public class BookService
    {
        private BookDAO bookdb;

        public BookService()
        {
            bookdb = new BookDAO();
        }

        public List<Book> GetAll()
        {
            List<Book> books = bookdb.GetAll();
            return books;
        }

        public List<Book> GetByAuthor(string authorName)
        {
            return bookdb.GetByAuthor(authorName);
        }
    }
}
