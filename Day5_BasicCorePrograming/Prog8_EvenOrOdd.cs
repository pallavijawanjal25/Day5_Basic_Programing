using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_BasicCorePrograming
{
    static class Prog8_EvenOrOdd
    {
        public static void EvenOrOdd()
        {
            Console.Write("Please enter a number:  ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is an even number");
            }
            else
            {
                Console.WriteLine(number + " is an odd number");
            }
        }
    }
}
