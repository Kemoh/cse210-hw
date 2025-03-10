using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Call the DisplayWelcomeMessage function:
        DisplayWelcomeMessage();

        // Call the PromptUserName function and assign it to a variable of type string:
        string userName = PromptUserName();

        // Call the PromptUserNumber function of datatype int:
        int userNumber = PromptUserNumber();

        // Call the SquareNumber function of type int:
        int squareNumber = SquareNumber(userNumber);

        // Call the DisplayResult function:
        DisplayResult(userName, squareNumber);


        // Part 1 of the program:
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program! ");
        }

        // Part 2 of the program:
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name  = Console.ReadLine();

            return name;
        }

        // Part 3 of the program:
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        // Part 4 of the program:
        static int SquareNumber(int number)
        {
            int square = number * number;

            return square;
        }

        // Part 5 of the program:
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your name is {square}.");
        }
    }
}