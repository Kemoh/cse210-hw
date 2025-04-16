// GoalManager.cs
using System.Runtime.InteropServices;

public class GoalManager
{
    // Declare the attributes for this class:
    private List<Goal> _goals;
    private int _score;

    // Declare constructors for this class and assign values:
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // Create the DisplayPalyerInfo method:
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    // Create the ListGoalNames method:
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    // Create the ListGoalDetails method:
    public void ListGoalDetails()
    {
        Console.WriteLine("Your Goals:");
        ListGoalNames();
    }
    
    // Create the Goal method:
    public void CreateGoal()
    {
        // Create the goals options:
        Console.WriteLine("\nThe type of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("\nWhich type of goal would you like to create? : "); string choice = Console.ReadLine();

        Console.Write("\nWhat is the name of your goal? : ");
        string name = Console.ReadLine();

        Console.Write("\nWhat is a short description of it? : ");
        string desc = Console.ReadLine();

        Console.Write("\nWhat is the amount of points associated with your goal? : ");
        int points = int.Parse(Console.ReadLine());

        // At the start of the game:
        Goal goal = null;

        // Start the Game method
        switch (choice)
        {
            case "1": goal = new SimpleGoal(name, desc, points);
                break;

            case "2": goal = new EternalGoal(name, desc, points);
                break;
                
            case "3":
                Console.Write("\nHow many times this goal this goal needs to be accomplished for a bonus? : ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("\nWhat is the bonus for accomplishing it that many times? : ");
                int bonus = int.Parse(Console.ReadLine());

                goal = new ChecklistGoal(name, desc, points, target, bonus);
                break;
        }

        // Add goals to the list
        if (goal != null)
            _goals.Add(goal);
    }

    // Create the RecordEvent method
    public void RecordEvent()
    {
        Console.WriteLine("\nWhich goal did you accomplish? ");
        ListGoalNames();

        Console.Write("Enter number: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < _goals.Count)
        {
            int points = _goals[index].RecordEvent();
            _score += points;
            Console.WriteLine($"You earned {points} points!");
        }
    }

    // Create the SaveGoals method
    public void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    // Create the LoadGoals method
    public void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);
            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                string type = parts[0];
                if (type == "SimpleGoal")
                {
                    var goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                    goal.SetCompletionStatus(bool.Parse(parts[4]));
                    _goals.Add(goal);
                }

                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                }

                else if (type == "ChecklistGoal")
                {
                    var goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[4]));
                    goal.SetAmountCompleted(int.Parse(parts[6]));
                    _goals.Add(goal);
                }
            }
        }

        else
        {
            Console.WriteLine("File not found.");
        }
    }
}