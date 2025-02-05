using System;

namespace whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a non-negative integer:");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number) && number >= 0)
            {
                int factorial = fact(number);
                Console.WriteLine($"The factorial of {number} is: {factorial}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            }
        }

        static int fact(int n)
        {
            int factorial = 1;
            int i = 1;
            while (i <= n)
            {
                factorial *= i;
                i++;
            }
            return factorial;
        }
    }
}
