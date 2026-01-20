using System;
using System.Collections.Generic;
using System.Text;
//      Find the LCM (Least Common Multiple) of two given numbers.
namespace CSharpcodepractice
{
    internal class While19
    {
       internal  static void LCM()
        {
            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            int hcf = FindHCF(a, b);

            int lcm = (a * b) / hcf;

            Console.WriteLine("LCM is: " + lcm);
        }

        static int FindHCF(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
