using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial18THIS
{
    class Book
    {
        private string Name, Author;

        public Book(string Name, string Author)
        {
            this.Name = Name;

            this.Author = Author;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetAuthor()
        {
            return Author;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book Test = new Book("Harrison Bergeron", "Kurt Vonnegut");

            Console.WriteLine("{0} is the author of {1}", Test.GetAuthor(), Test.GetName());

            Console.ReadLine();
        }
    }
}
