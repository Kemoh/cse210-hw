using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your garde percentage? ");
        string response = Console.ReadLine();
        int percentage = int.Parse(response);

        string grade = "";

        if (percentage >= 90)
        {
            grade = "A";
            Console.WriteLine(grade);
        }
        else if (percentage >=80)
        {
            grade = "B";
            Console.WriteLine(grade);
        }
        else if (percentage >=70)
        {
            grade = "C";
            Console.WriteLine(grade);
        }
        else if (percentage >=60)
        {
            grade = "D";
            Console.WriteLine(grade);
        }
        else 
        {
            grade = "F";
            Console.WriteLine(grade);
        }

         // Second Part
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

    }     
}