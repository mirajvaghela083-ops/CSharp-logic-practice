using System;
using System.Collections.Generic;
using System.Text;
//Find the HCF (Highest Common Factor) of two given numbers.
namespace DemoProject2
{
    internal class While18
    {
        internal static void Hcf()
        {
            Console.WriteLine("The first number is :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The second number is :");
            int num2 = Convert.ToInt32(Console.ReadLine());

             if(num1 == 0 && num2 == 0)
            {
                Console.WriteLine("Please take the positive number ");
            }
            int x1 = 1;
            int hcf = 1;
            while(x1<=num1 && x1 <= num2)
            {
                    if(num1 % x1 == 0 && num2 % x1 == 0)
                {
                    hcf = x1;
                }
                x1++;
            }
            Console.WriteLine($"HCF is : {hcf}");

        }
    }
}
