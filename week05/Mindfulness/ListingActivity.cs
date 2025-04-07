using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity(int duration) : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 
        duration)
    {
        _prompts = new List<string>
        {
            "\nWho are the people that you appreciate?",
            "\nWhat are the personal strengths of yours?",
            "\nWho are the people that you have helped this week?",
            "\nWhen have you felt the Holy Ghost this month?",
            "\nWho are some of your personal heroes?"
        };
    }

    // Run the activity
    public void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(5);

        Random random = new Random();
        int elapsedTime = 0;

        // Select a random prompt
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
         // Time to think
        ShowCountDown(3);

        List<string> userList = new List<string>();

        Console.WriteLine("\nStart listing! Type 'done' when finished.");
        while (elapsedTime < _duration)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done") break;

            userList.Add(input);
            // Simulate thinking time for each item listed
            elapsedTime += 5; 
        }

        Console.WriteLine($"\nYou listed {userList.Count} items.");
        DisplayEndingMessage();
    }
}
