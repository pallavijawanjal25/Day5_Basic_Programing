using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_BasicCorePrograming
{
    public static class LargestAmongThree
    {
        public   static void CheckLargestNumber()
        {
            int n1, n2, n3, largest;
            Console.WriteLine("Enter the Number 1");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number 2");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number 3");
            n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
                largest = n1;
            else if (n2 > n1 && n2 > n3)
                largest = n2;
            else
                largest = n3;
Console.WriteLine("Largest number Among Three {0},{1},{2}is{3}",n1,n2,n3,largest);
            Console.WriteLine();
        }
    }
}

