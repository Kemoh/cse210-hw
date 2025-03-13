using System;

// Create the Resume class:
public class Resume
{
    // Create the member variable for the person's name:
    public string _name;

    // Create the member variable for the list of jobs:
    public List<Job> _jobs = new List<Job>();

    // Add a display method to the Resume class:
    public void DisplayResumeDetails()
    {   // In the method body, you should display the
        //  person's name and then iterate through each Job
        //  instance in the list of jobs and display them.
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        
         // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in _jobs)
        {
            // This calls the Display method on each job
            job.DisplayJobDetails();   
        }
    }
}