public class Fraction
{
    // Create the class attributes/member variable:
    private int _top;
    private int _bottom;

    //Create the Constructors
    //1. Create a constructor with no parameters and sets the initial number to 1/1:
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    //2. Create a Constructor that has one parameter for the top and sets the bottom to 1, i.e. top/1:
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    //3. Create a Constructor that has two parameters for top and bottom:
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // // Before implementing the Getter and Setter Menthods:
    // public void Display()
    // {
    //     Console.WriteLine($"{_top} / {_bottom}");
    // }

    // Create a Getter and Setter methods to display the Constuctors:
    public string GetFractionString()
    {
        // Notice that this is not stored as a member variable.
        // It is just a temporal local varibale that will be recomputed 
        // each time this is called.
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        // Notice that this is not stored as a member variable.
        // It is just a temporal local varibale that will be recomputed 
        // each time this is called.
        return (double)_top / (double)_bottom;
        
    }

}