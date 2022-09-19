using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_BasicCorePrograming
namespace ConsoleAppPracticeBasic_Logical
{
    public static class SwapingNumber
    {
        public static void SwapTwoNo()
        {
            int a;
            int b;
           int temp;

            Console.WriteLine("enter value of a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter value of b:");
            b= int.Parse(Console.ReadLine());
            Console.WriteLine("before swaping Number is a={0},b={1}",a,b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swaping Number is a={0},b={1}",a,b);
            Console.ReadLine();


        }
    }
}
