using System;

public class BreathingActivity : Activity
{
    // Define constructors for this class
    public BreathingActivity(int duration) : base("Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 
        duration) { }

    // Run the activity
    public void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(5);

        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.WriteLine("Breathe in...");
            // Simulate breathing in (4 seconds)
            ShowCountDown(4); 
            elapsedTime += 4;

            Console.WriteLine("Breathe out...");
            //Simulate breathing out (4 seconds)
            ShowCountDown(4); 
            elapsedTime += 4;
        }

        DisplayEndingMessage();
    }
}
