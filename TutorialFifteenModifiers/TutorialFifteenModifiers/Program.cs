using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialFifteenModifiers
{
    class Book
    {
        private int Pages = 10;

        public int GetPages()
        {
            return Pages;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book X = new Book();

            Console.WriteLine(X.GetPages());

            Console.ReadLine();
        }
    }
}
