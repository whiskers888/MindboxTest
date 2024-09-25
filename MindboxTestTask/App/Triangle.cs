namespace MindboxTestTask.App
{
    public class Triangle : IShape
    {
        double A { get; }
        double B { get; }
        double C { get; }
        public Triangle(double a, double b, double c)
        {
            if (A <= 0 || B <= 0 || C <= 0) throw new Exception("Все стороны треугольника должны быть положительными и не равными нулю");
            A = a; B = b; C = c;
        }
        public double CalculateArea()
        {
            double p = (A + B + C) / 2;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area;
        }

        public bool IsRectangularTriangle()
        {
            List<double> sides = [A, B, C];
            sides.Sort();
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}
