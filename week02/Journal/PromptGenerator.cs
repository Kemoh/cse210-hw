using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // Declare And Instatiate A List Object To Hold The
    //  Prompts:
    public List<string> _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is the summary of your expenditure today?",
            "Were you able to meet your targets for today? ",
            "Did you take your medications today? ",
            "How was your day? "
        };

    // Create A Method To Return A random prompt: 
    public string GetRandomPrompt()
    {
        // Instantiate An Object  Random class:
        Random random = new Random();

        //Get A Random Index For The Prompts:
        int randomIndex = random.Next(_prompts.Count);

        // Return A Random Prompt:
        return _prompts[randomIndex];
    }
}

