// Goal.cs
public abstract class Goal
{
    // Declare attributes for this class:
    protected string _shortName;
    protected string _description;
    protected int _points;

    // Declare the constructor for this class and assign it to the parameters:
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Declare methods for this class:
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();
}
