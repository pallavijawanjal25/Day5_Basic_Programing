using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_BasicCorePrograming
{
static class Prog7_SwapTwoNumbers
    {
        public static void SwapNumbers()
        {
  
            Console.Write("Enter first number:  ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number:  ");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\n\n\nNumbers before swapping -   ");
            Console.WriteLine("First number :   " + a);
            Console.WriteLine("Second number :   " + b);

           
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("\n\n\nNumbers after swapping -   ");
            Console.WriteLine("First number :   " + a);
            Console.WriteLine("Second number :   " + b);





        }
    }
}
