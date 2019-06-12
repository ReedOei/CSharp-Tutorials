using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial18Constructor
{
    class Book
    {
        private string Name, Author;

        public Book(string BookName, string AuthorOfBook)
        {
            Name = BookName;
            Author = AuthorOfBook;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book Test = new Book("Midnight's Children", "Salmon Rushdie");

            Console.ReadLine();
        }
    }
}
