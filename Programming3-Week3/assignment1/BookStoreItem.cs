using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    abstract class BookStoreItem
    {
        private string title;
        private float price;
        private int count;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Count
        {
            get { return count;}
            set { count = value; }
        }

        public float TotalPrice
        {
            get { return count * price; }
        }

        public BookStoreItem(string title, float price, int count)
        {
            this.title = title;
            this.price = price;
            this.count = count;
        }

        public abstract void Print();
    }
}
