using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of terms in the sequence: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int numberOfTerms) && numberOfTerms > 0)
            {
                Console.WriteLine($"The Fibonacci sequence with {numberOfTerms} terms is:");
                int a = 0, b = 1;
                Console.Write($"{a}, {b}");
                for (int i = 2; i < numberOfTerms; i++)
                {
                    int c = a + b;
                    Console.Write($", {c}");
                    a = b;
                    b = c;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }
    }
}
