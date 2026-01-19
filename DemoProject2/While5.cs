using System;
using System.Collections.Generic;
using System.Text;
// count and print the total nnumber of digit in a given number .
namespace DemoProject2
{
    internal class While5
    {
        internal static void totalOf()
        {
            Console.WriteLine("The number is :");
            int num = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            while (num > 0) 
            { 
                 num = num / 10;
                 count ++;
            }
            Console.WriteLine(count);
        }
    }
}
