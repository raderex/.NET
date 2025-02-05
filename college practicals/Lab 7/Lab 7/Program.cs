using System;

namespace methodOverriding
{
    class Shape
    {
        public virtual double Area()
        {
            return 0;
        }
    }
    class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return Height * Width;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle { Height = 10, Width = 12 };
            Console.WriteLine("Area of the Rectangle: " + rectangle.Area());
        }
    }
}
