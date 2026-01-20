// Print the square of each number from 1 to n.
namespace DemoProject2
{
    internal class While14
    {
        internal static void square()
        {
            Console.WriteLine(" The Number Is :");
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            /* while(i <= n )
               {
                   double num = Math.Pow(n, 2);
                   n--;
                   Console.WriteLine(num);
               }     */
            while (i <= n)
            {
                int square = i * i;
                Console.WriteLine(square);
                i++;
            }

        }
    }
}
