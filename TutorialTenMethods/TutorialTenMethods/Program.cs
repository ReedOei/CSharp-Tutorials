using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialTenMethods
{
    class Program
    {
        static void DoMath()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = x * 5 + 5;
            int z = 25 / y;

            Console.WriteLine(x + y + z);
        }

        static void Main(string[] args)
        {
            DoMath();

            Console.ReadLine();
        }
    }
}
