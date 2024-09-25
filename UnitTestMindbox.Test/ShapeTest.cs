using MindboxTestTask.App;
using NUnit.Framework;

[TestFixture]
public class ShapeTest
{
    [Test]
    public void Circle_CalculateArea()
    {
        var circle = new Circle(5);
        Assert.Equals(78.53981633974483, circle.CalculateArea());
    }

    [Test]
    public void Triangle_CalculateArea()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Equals(6, triangle.CalculateArea());
    }

    [Test]
    public void Triangle_IsRectangularTriangle_ValueTrue()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Equals(triangle.IsRectangularTriangle(), true);
    }

    [Test]
    public void Triangle_IsRectangularTriangle_ValueFalse()
    {
        var triangle = new Triangle(3, 4, 6);
        Assert.Equals(triangle.IsRectangularTriangle(), false);
    }

    [Test]
    public void Triangle_SetWrongValue()
    {
        Assert.Throws<Exception>(() => new Triangle(-1, 2, -3));
    }

    [Test]
    public void Circle_SetWrongValue()
    {
        Assert.Throws<Exception>(() => new Circle(-1));
    }
}