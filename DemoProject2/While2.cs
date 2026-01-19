using System;
using System.Collections.Generic;
using System.Text;
// Calculate the sum of all even number from 1 up to n also for odd .
namespace DemoProject2
{
    internal class While2
    {
        internal static void sumof()
        {
            Console.WriteLine("the number is :");
            int number = Convert.ToInt32(Console.ReadLine());

            int Even = 2; // int odd = 1 ;
            int Sum = 0;

            while (Even <= number) {
                Sum += Even;
                Even += 2;
            }
            Console.WriteLine(Sum);
        }
    }
}
