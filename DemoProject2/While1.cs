// Calculate and print the sum of the first n natural number .
namespace DemoProject2
{
    internal class While1
    {
        internal static void sum()
        {
            Console.WriteLine(" the natural number is :");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int num = 1;

            while (num <= number)
            {
                sum += num; // sum = sum + num ;
                num++;
            }
            Console.WriteLine("Sum of first " + num + " natural numbers is: " + sum);
        }

    }
}
