using System;

public class Activity
{
    // Declare the attributes for this class that will be inherited by other classes
    protected string _name;
    protected string _description;
    protected int _duration;

    // Define the Constructor for this class
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    // Display starting message
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"{_name}\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How many seconds would you like to spend on this activity? ");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Get ready to begin...\n");
         // Simulate pause
        ShowSpinner(3);
    }

    // Display ending message
    public void DisplayEndingMessage()
    {
        ShowSpinner(3); // Simulate pause
        Console.WriteLine("\nGood job! You’ve completed the activity.");
        Console.WriteLine($"\nYou spent {_duration} seconds on the activity.");
        ShowSpinner(3); // Simulate pause
    }

    // Show Spinner (animation)
    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        for (int i = 0; i < seconds; i++)
        {
            foreach (var symbol in spinner)
            {
                Console.Write($"\r{symbol}");
                System.Threading.Thread.Sleep(250); // Pause for animation
            }
        }
        Console.WriteLine();
    }

    // Show countdown timer
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write($"\rStarting in {i}...");
            System.Threading.Thread.Sleep(1000); // Wait for 1 second
        }
        Console.WriteLine();
    }
}
