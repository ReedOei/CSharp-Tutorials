using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialFourteenClasses
{
    class Author
    {
        public string FirstName, LastName;
    }

    class Book
    {
        public string Type;
        public string Author;
        public int Pages;

        public int AuthorBirthDate;
        public string AuthorFirstName;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book x = new Book();
            x.Type = "Fiction";

            Book y = new Book();
            y.Type = "Nonfiction";

            Console.WriteLine(x.Type);
            Console.WriteLine(y.Type);

            Console.ReadLine();
        }
    }
}
