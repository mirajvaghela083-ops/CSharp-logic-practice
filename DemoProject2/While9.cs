// Check whether the given number is a Perfect number. 
namespace DemoProject2
{
    internal class While9
    {
        internal static void perfect()
        {
            int number = 6;

            int i = 1;

            int sum = 0;

            while (i < number)
            {
                if (number % i == 0)
                {
                    sum += i;
                }

                i++;
            }
            if (sum == number)
            {
                Console.WriteLine("perfect");
            }
            else
            {
                Console.WriteLine("not");
            }
        }
    }
}
