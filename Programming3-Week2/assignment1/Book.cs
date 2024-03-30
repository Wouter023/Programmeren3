using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Book : BookStoreItem
    {
        public string Author;
        public BookTypes bookType;

        public Book(string title, string author, float price) : base(title,price)
        { 
            this.Author = author;
        }

        public override void Print()
        {
            Console.WriteLine($"[Book] '{Title}' by {Author}, {Price:0.00}");
        }
    }
}
