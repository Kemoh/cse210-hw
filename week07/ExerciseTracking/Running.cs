public class Running : Activity
{
    //Declare member variable specific to this class:
    private double _distance;

    //Constructor to initialize this class:
    public Running(string date, int acticityLength, double distance) : base(date, acticityLength)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / minutes * 60;
    }

    public override double GetPace()
    {
        return minutes / _distance;
    }

}