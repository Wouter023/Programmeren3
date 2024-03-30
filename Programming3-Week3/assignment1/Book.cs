using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Book : BookStoreItem
    {
        private string author;
        private BookTypes bookType;

        public string Author
        {
            get;
            private set;
        }

        public BookTypes BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }

        public Book(string title, string author, float price, int count) : base(title,price,count)
        { 
            this.Author = author;
        }

        public override void Print()
        {
            Console.WriteLine($"[Book] '{Title}' by {Author}, {Price:0.00} ({Count}x)");
        }
    }
}
