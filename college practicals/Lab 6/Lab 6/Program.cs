using System;

namespace methodOverloading
{
    class Program
    {
        void printData(int i)
        {
            Console.WriteLine("Int: {0}", i);
        }
        void printData(double i)
        {
            Console.WriteLine("Float: {0}", i);
        }
        void printData(string i)
        {
            Console.WriteLine("String: {0}", i);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.printData(21);
            p.printData(192.68);
            p.printData("Hello world!");
        }
    }
}