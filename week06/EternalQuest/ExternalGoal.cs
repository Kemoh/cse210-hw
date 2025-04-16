// EternalGoal.cs
public class EternalGoal : Goal
{
    // Create the constructor for the EternalGoal 
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    // Create the methods for this class
    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal: {_shortName},{_description},{_points}";
    }
}
