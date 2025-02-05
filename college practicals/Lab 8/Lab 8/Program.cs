using System;

namespace inheritance
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Employee : Person
    {
        public double Salary { get; set; }

        public void DisplayEmployeeInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Salary: {Salary}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee { Name = "Ram Bahadur", Age = 35, Salary = 30000 };
            employee.DisplayEmployeeInfo();
        }
    }
}
