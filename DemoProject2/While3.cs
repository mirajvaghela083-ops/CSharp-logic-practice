using System;
using System.Collections.Generic;
using System.Text;
// calculate and print the factorial of a given number .
namespace DemoProject2
{
    internal class While3
    {
        internal static void fun()
        {
            Console.WriteLine(" the factorail number is :");
            int nummber = Convert.ToInt32(Console.ReadLine());

            int Fact = 1;
            int i = 1;
             while ( i <= nummber)
            {
                Fact = Fact * i;
               i++;

            }
             Console.WriteLine(Fact);
        }
    }
}
