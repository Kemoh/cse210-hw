public class Circle : Shape
{
    // Create the attribute for the Circle Class:
    private double _radius;

    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}