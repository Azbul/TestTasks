namespace AreaTriangleSquareLibrary
{
    public abstract class Shape
    {
        public abstract double Area { get; }

        protected double CheckIfValueIsPositive(double value)
        {
            if (value <= 0)
                throw new System.ArgumentException($"Неверные параметры {GetType()}: все значения должны быть больше нуля");

            return value;
        }
    }
}
