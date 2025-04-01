using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Create a new job instance named job1:
        Job job1 = new Job();

        //  Set the member variables using the dot
        //  notation:
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Create a new job instance named job2:
        Job job2 = new Job();

        // Set the member variables using the dot
        //  notation:
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Displays the company of job1 and job2:
        //Console.WriteLine(job1._company);
        //Console.WriteLine(job2._company);

        // Display the job datails in the required format
        // Call the DisplayJobDetails() using the dot
        //  notation for job1 and job2:
        //job1.DisplayJobDetails();
       // job2.DisplayJobDetails();


        // Create a new instance of the Resume class and stored it in a varible named myResume:
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        //Console.WriteLine( myResume._name);

        //Add the two jobs you created earlier, to the list
        //  of jobs in the resume object.
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Verify that you can access and display the first
        //  job title using dot notation similar to 
       // myResume._jobs[0]._jobTitle;
        //Console.WriteLine($"First Job Title: {myResume._jobs[0]._jobTitle}");


        //  Add a call at the end to the Display method from your Resume class to display the name and all the jobs in one line.
        myResume.DisplayResumeDetails();
    }
}

