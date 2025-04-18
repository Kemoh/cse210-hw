public class Swimming : Activity
{
    //Declare member variable specific to this class:
    private int _laps;

    public Swimming(string date, int acticityLength, int laps) : base(date, acticityLength)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // 1 lap = 50 meters
        return _laps * 50 / 1000 ;
    }

    public override double GetSpeed()
    {
        return GetDistance() / minutes * 60;
    }

    public override double GetPace()
    {
        return minutes / GetDistance();
    }
}