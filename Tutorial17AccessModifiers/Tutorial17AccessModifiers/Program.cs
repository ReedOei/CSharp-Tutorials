using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial17AccessModifiers
{
    class Book
    {
        public static int Pages
        {
            get
            {
                return Pages;
            }
            set
            {
                Pages = value;
            }
        }
    }

    class Program
    {
        public static double G = 6.67E-11;

        static void Main(string[] args)
        {
            Book.Pages = 10;

            Console.WriteLine(Book.Pages);

            Console.ReadLine();
        }
    }
}
