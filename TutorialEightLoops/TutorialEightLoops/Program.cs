using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialEightLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int Increment = 0;
            while (Increment < 10000)
            {
                Console.WriteLine(Increment);
                Increment++;
            }

            Console.ReadLine();
        }
    }
}
