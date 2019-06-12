using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialNine
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = { 2, 5, 6, 7, 12, 8, 1235, 60 };
            int x = 0;

            foreach (int Add in Numbers)
            {
                x += Add;
            }

            Console.WriteLine(x / Numbers.Length);

            Console.ReadLine();
        }
    }
}
