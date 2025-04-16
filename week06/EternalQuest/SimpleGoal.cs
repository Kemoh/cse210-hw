// SimpleGoal.cs
public class SimpleGoal : Goal
{
    // Declare the attribute for this class
    private bool _isComplete;

    // Create the constructors for this class
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    // Create the RecordEvent method
    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    // Create the IsComplete method
    public override bool IsComplete()
    {
        return _isComplete;
    }

    
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }

    public bool IsCompleted() => _isComplete;
    public void SetCompletionStatus(bool status) => _isComplete = status;
}
