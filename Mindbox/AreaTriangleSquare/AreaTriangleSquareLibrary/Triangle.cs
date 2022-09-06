using System;

namespace AreaTriangleSquareLibrary
{
    public class Triangle : Shape
    {
        double _a;
        double _b;
        double _c;

        public Triangle()
        { }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

            if (IsCorrectTriangle == false)
                throw new ArgumentException("Неверно указаны стороны треугольника");
        }

        public double A
        {
            get => _a;
            set => _a = CheckIfValueIsPositive(value);
        }

        public double B
        {
            get => _b;
            set => _b = CheckIfValueIsPositive(value);
        }

        public double C
        {
            get => _c;
            set => _c = CheckIfValueIsPositive(value);
        }

        public override double Area => Math.Sqrt(SemiPerimmeter * (SemiPerimmeter - A) * (SemiPerimmeter - B) * (SemiPerimmeter - C));

        public bool IsCorrectTriangle => (_a + _b) > _c && (_a + _c) > _b && (_b + _c) > _a;

        private double SemiPerimmeter => (A + B + C) / 2;

    }
}
