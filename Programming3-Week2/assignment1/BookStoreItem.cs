using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    abstract class BookStoreItem
    {
        public string Title;
        public float Price;

        public BookStoreItem(string title, float price)
        {
            Title = title;
            Price = price;
        }

        public abstract void Print();
    }
}
