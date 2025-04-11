using System;

public class Square : Shape
{
    // Create the attribute for the Square class:
    private double _side;

    // Create a constructor for the Square Class:
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

     // Notice the use of the override keyword here
    public override double GetArea()
    {
        return _side * _side;
    }

}