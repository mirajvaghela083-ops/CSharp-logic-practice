using System;
using System.Collections.Generic;
using System.Text;
// check whether the given number is palindrome

namespace DemoProject2
{
    internal class While7
    {
        internal static void number()
        {
            int num = 121;

            int orginal = num;

            int palindrome = 0;

            while (num > 0)
            {
                int number = num % 10;
                palindrome = palindrome * 10 + number;
                num = num / 10;
                
            }
            
            if (palindrome == orginal)
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("Nothing");
            }
            Console.WriteLine(palindrome);
        }
    }
}
