public class Cycling : Activity
{
     //Declare member variable specific to this class:
    private double _speed;

    public Cycling(string date, int acticityLength, double speed) : base(date, acticityLength)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * minutes) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}