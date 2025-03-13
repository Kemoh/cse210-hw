using System;

// Create the Job class:
public class Job
{
    // Create member variables:
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Add a display method to the Job class:
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}"); 
    }
}