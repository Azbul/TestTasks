using System;
using AreaTriangleSquareLibrary;

namespace AreaTriangleSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Triangle(5, 8, 11);
            Console.WriteLine($"Area of Triangle: {shape.Area}");

            shape = new Circle(10);
            Console.WriteLine($"Area of Circle: {shape.Area}");

            Console.ReadKey();
        }
    }
}
