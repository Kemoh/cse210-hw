using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // Create A List To Store The Journal Entries:
    public List<Entry> _entries = new List<Entry>();


    // Create A Method To Add An Entry To THe List
    public void AddEntry(Entry newEntry)
    {
        // Adds The Passed Entry Object To The
        //  List 
        _entries.Add(newEntry);
    }

    // Create A Method To Display All Journal
    //  Entries:
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No Journal Entries Found.");
            return;
        }

        foreach (var entry in _entries)
        {
            // Call The Display Method From The
            // Entry Class:
            entry.Display();
        }
    }

    // Create A  Method to Save Journal Entries To A File:
    public void SaveToFile(string fileName)
    {
        // Display This Line Of Text For Checking
        Console.WriteLine("Saving file...");

        using (StreamWriter outputFile = new StreamWriter(fileName))

        foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        Console.WriteLine($"{fileName} saved successfully.");
    }

    // Create A Method To Load Journal Entries
    //  From A File:
    public void LoadFromFile(string fileName)
    {
        // Check If The File Exists:
        if (File.Exists(fileName))
        {
            // Clear Existing Entries Before
            //  Loading:
            _entries.Clear();

            // Display This Line Of Text For
            //  Checking
            Console.WriteLine("Loading file...");

            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                // Split The Saved Data:
                string[] parts = line.Split("|");
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];

                    Console.WriteLine($"{date}|{prompt}|{response}");
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
        Console.WriteLine("File not found.");
        }            
    }
}
       