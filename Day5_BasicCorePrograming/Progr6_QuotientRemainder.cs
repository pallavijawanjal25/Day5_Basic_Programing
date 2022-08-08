using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_BasicCorePrograming
{
  static class Progr6_QuotientRemainder
    {
        public static void QuotientRemainder()
        {
            Console.WriteLine("Enter values of dividend and divisor:  ");

            Console.Write("Dividend = ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Divisor = ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient, remainder;

            quotient = dividend / divisor;
            remainder = dividend % divisor;

            Console.WriteLine("\n\nQuotient is  " + quotient);
            Console.WriteLine("Remainder is  " + remainder);
        }
    }
}
