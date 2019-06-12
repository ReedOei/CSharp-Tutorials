using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial16Switcch
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3, y = 10;

            switch (x)
            {
                case y:
                case 1:
                case 2:
                    Console.WriteLine("X is nothing.");
                    break;

                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
