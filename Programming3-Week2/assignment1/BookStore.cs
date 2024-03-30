using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class BookStore
    {
        private List<BookStoreItem> books = new List<BookStoreItem>();
        float totalPrice = 0;

        public void Add(BookStoreItem bookStoreItem)
        {
            books.Add(bookStoreItem);
        }

        public void PrintCompleteStock()
        {
            for (int i = 0; i < books.Count; i++)
            {
                books[i].Print();
                totalPrice += books[i].Price;
            }
            Console.WriteLine($"Total sales price: {totalPrice:00.00}");
        }
    }
}
