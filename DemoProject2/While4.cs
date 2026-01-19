using System;
using System.Collections.Generic;
using System.Text;
//find and print the product of all digits of a given number ; sum also 

namespace DemoProject2
{
    internal class While4
    {
        internal static void funof()
        {
            Console.WriteLine("The digit is :");
            int digit = Convert.ToInt32 (Console.ReadLine());

            int sum = 0; // int sum = 1;
            while (digit > 0)
            {
                int number  = digit % 10;
                sum += number;
                //sum = sum * number;
                digit = digit / 10;

            }
            Console.WriteLine(sum);
        }
    }
}
