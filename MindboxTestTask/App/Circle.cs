namespace MindboxTestTask.App
{
    public class Circle : IShape
    {
        int Radius { get; }

        public Circle(int radius)
        {
            if (radius <= 0) throw new Exception("Радиус не может быть отрицательным ил равным нулю");
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
