using System;

namespace AreaTriangleSquareLibrary
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle()
        { }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get => _radius;
            set => _radius = CheckIfValueIsPositive(value);
        }

        public override double Area => Math.PI * Radius * Radius;
    }
}
