using System;

namespace doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueProgram;
            do
            {
                Console.Write("Enter the upper limit: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int limit) && limit > 0)
                {
                    int sum = SumOfEvenNumbers(limit);
                    Console.WriteLine($"The sum of even numbers from 1 to {limit} is: {sum}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                }
                Console.Write("Do you want to calculate again? (y/n): ");
                string response = Console.ReadLine();
                continueProgram = (response.ToLower() == "y");
            } while (continueProgram);
        }

        static int SumOfEvenNumbers(int limit)
        {
            int sum = 0;
            for (int i = 2; i <= limit; i += 2)
            {
                sum += i;
            }
            return sum;
        }
    }
}
