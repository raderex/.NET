using System;

namespace staticClass
{
    public static class Calculator
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int subtract(int a, int b)
        {
            return a - b;
        }
        public static int multiply(int a, int b)
        {
            return a * b;
        }
        public static double divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Division by zero is not allowed.");
            }
            return (double)a / b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum: " + Calculator.add(5, 3));
            Console.WriteLine("Difference: " + Calculator.subtract(10, 4));
            Console.WriteLine("Product: " + Calculator.multiply(6, 7));
            Console.WriteLine("Division: " + Calculator.divide(20, 4));
        }
    }
}
