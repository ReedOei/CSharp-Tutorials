using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialFiveElseIf
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
            else if (Input == 2)
            {
                Console.WriteLine("I suppose that is fine.");
            }
            else
            {
                Console.WriteLine("I disagree!");
            }

            Console.ReadLine();
        }
    }
}
