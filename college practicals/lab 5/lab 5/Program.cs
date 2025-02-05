using System;

namespace forEach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers separated by spaces: ");
            string input = Console.ReadLine();
            string[] numberStrings = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[numberStrings.Length];

            for (int i = 0; i < numberStrings.Length; i++)
            {
                if (int.TryParse(numberStrings[i], out int number))
                {
                    numbers[i] = number;
                }
                else
                {
                    Console.WriteLine($"Invalid input: '{numberStrings[i]}' is not a valid integer.");
                    return;
                }
            }
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"The sum of the numbers is: {sum}");
        }
    }
}
