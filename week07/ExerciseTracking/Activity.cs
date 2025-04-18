using System;
public abstract class Activity
{
    //Member variables shared by derived
    // classes:
    private DateTime _date;
    private int _activityLength;

    //Constructor to initialize date and time:
    public Activity(string date, int activityLength)
    {
        _date = DateTime.Parse(date);
        _activityLength = activityLength;
    }

    // Properties for date and acticityLength
    public DateTime Date => _date;
    public int minutes => _activityLength;

    //Declare Abstract methods to implement in derived classes:
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Method to return summary of activity:
    public string GetSummary()
    {
       // Use DateTime's ToString method with the format string to correctly display the date
    return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({minutes} min) - " +
           $"Distance {GetDistance():F1} km, Speed {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }

}