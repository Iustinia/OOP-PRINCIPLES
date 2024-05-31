using System;

namespace GeometricShapes
{
 
    public interface IShape
    {
        public double CalculateArea();
    }

    
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }

    public class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new()
            {
                new Circle(5),
                new Rectangle(4, 6),
                new Triangle(4, 3)
            };

            PrintShapes(shapes);
        }

        private static void PrintShapes(List<IShape> shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine($"The area of the {shape.GetType().Name} is {shape.CalculateArea()}");
            }
        }
    }
}