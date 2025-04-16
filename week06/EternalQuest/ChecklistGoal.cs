// ChecklistGoal.cs
public class ChecklistGoal : Goal
{
    // Declare the attributes for this class
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Create the constructor for this class
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted == _target)
        {
            return _points + _bonus;
        }
        return _points;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName}, ({_description}), Completed: {_amountCompleted} / {_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {_shortName},{_description},{_points}|{_bonus},{_target},{_amountCompleted}";
    }

    public void SetAmountCompleted(int amount) => _amountCompleted = amount;
}
