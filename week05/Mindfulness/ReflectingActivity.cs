using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(int duration) : base("Reflecting Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
        duration)
    {
        _prompts = new List<string>
        {
            "\nThink of a time when you stood up for someone else.",
            "\nThink of a time when you did something really difficult.",
            "\nThink of a time when you helped someone in need.",
            "\nThink of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "\nWhy was this experience meaningful to you?",
            "\nHave you ever done anything like this before?",
            "\nHow did you get started?",
            "\nHow did you feel when it was complete?",
            "\nWhat made this time different than other times when you were not as successful?",
            "\nWhat is your favorite thing about this experience?",
            "\nWhat could you learn from this experience that applies to other situations?",
            "\nWhat did you learn about yourself through this experience?",
            "\nHow can you keep this experience in mind in the future?"
        };
    }

    // Run the activity
    public void Run()
    {
        DisplayStartingMessage();
        ShowCountDown(5);

        Random random = new Random();
        int elapsedTime = 0;

        while (elapsedTime < _duration)
        {
            // Select a random prompt
            string prompt = _prompts[random.Next(_prompts.Count)];
            Console.WriteLine($"Prompt: {prompt}");
            // Time to think
            ShowCountDown(3); 

            // Ask questions based on the prompt
            for (int i = 0; i < 3 && elapsedTime < _duration; i++) // Limit to 3 questions for brevity
            {
                string question = _questions[random.Next(_questions.Count)];
                Console.WriteLine($"\nQuestion: {question}");
                // Show pause animation
                ShowSpinner(3); 
                // Add time for each question and pause
                elapsedTime += 6; 
            }
        }
        DisplayEndingMessage();
    }
}
