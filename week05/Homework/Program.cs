using System;

class Program
{

    static void Main(string[] args)
    {
        
// Create a base assignment object
Assignment A1 = new Assignment("Joseph", "English");
Console.WriteLine(A1.GetSummary());

// Now create the derived class assignments
MathAssignment A2 = new MathAssignment("Nathaniel", "Fractions", "7.3", "8 - 10");
Console.WriteLine(A2.GetSummary());
Console.WriteLine(A2.GetHomeworkList());

WritingAssignment A3 = new WritingAssignment("Mary Waters", "European History", "The Causes Of World War II");
Console.WriteLine(A3.GetSummary());
Console.WriteLine(A3.GetWritingInformation());

    }
}
