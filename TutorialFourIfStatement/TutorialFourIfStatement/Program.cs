using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialFourIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            int Input = Convert.ToInt32(Console.ReadLine());

            if (Input < 2)
            {
                Console.WriteLine("Good choice!");
            }

            Console.ReadLine();
        }
    }
}
