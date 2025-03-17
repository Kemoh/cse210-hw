using System;
using System.Collections.Generic;

public class Entry
{
    // Declare The Member Variables:
    public string _date;
    public string _promptText;
    public string _entryText;

    // Create a Constructor to Initailize An Entry:
    public Entry (string promptText, string entryText)
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = promptText;
        _entryText = entryText;
    }

    // Define A Method To Display The Entry:
    // This is an implementation of the Principle of
    //  Abstraction
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();

    }
    
}