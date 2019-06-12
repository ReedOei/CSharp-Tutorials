using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialThreeInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string X = "";

            Console.WriteLine("What is your name?");
            X = Console.ReadLine();

            Console.WriteLine("Hello " + X + "!");
            Console.ReadLine();
        }
    }
}
