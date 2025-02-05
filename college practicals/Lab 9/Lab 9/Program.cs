using System;

namespace abstractClass
{
    abstract class Shape
    {
        abstract public double Area();
    }

    class Rectangle : Shape
    {
        private double Height, Width;

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double Area()
        {
            return Height * Width;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(11, 12);
            Console.WriteLine("Area of a rectangle = " + rectangle.Area());
        }
    }
}
