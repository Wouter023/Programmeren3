using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Book
    {
        private int id;
        public int Id { get { return id; } set { id = value; } }

        public string Title;
        public string Author;
        public Book(int id, string title, string author) { 
            this.id = id;
            this.Title = title;
            this.Author = author;
        }

        public override string ToString()
        {
            return $"'{Title}' by {Author}";
        }
    }
}
