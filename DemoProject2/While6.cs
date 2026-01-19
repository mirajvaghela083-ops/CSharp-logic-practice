using System;
using System.Collections.Generic;
using System.Text;
// Reverse the given number and print the reverse value .
namespace DemoProject2
{
    internal class While6
    {
       internal static void demo()
        {
            Console.WriteLine(" The given number is :");
            int num = Convert.ToInt32(Console.ReadLine());

            int reverse = 0;
            while (num > 0)
            {
                int number = num % 10;
                reverse = reverse * 10 + number;
                num = num / 10;
            }
            Console.WriteLine( reverse);
            }
    }
}
