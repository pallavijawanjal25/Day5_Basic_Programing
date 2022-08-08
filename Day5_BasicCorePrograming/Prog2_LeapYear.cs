using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_BasicCorePrograming
{
    static class Prog2_LeapYear
    {
        public static void LeapYear()
        {
            Console.Write("Please Enter Year:  ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 == 0)
            {
                Console.WriteLine("{0} is a Leap Year", year);

            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("{0} is not a Leap Year", year);
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("{0} is a Leap Year", year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year", year);
            }
        }
    }
}