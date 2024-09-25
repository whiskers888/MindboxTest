namespace MindboxTestTask.App
{
    public class Circle : IShape
    {
        double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0) throw new Exception("Радиус не может быть отрицательным или равным нулю");
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
