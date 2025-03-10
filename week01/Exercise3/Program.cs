using System;

class Program
{
    static void Main(string[] args)
    {
        // For Parts 1, where the user specified the number without a loop:
        Console.Write("What is the magic number? ");
        int magicNumber1 = int.Parse(Console.ReadLine());
        Console.Write("What is you guess? ");
        int guessedNumber1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Higher");

        Console.Write("What is the magic number? ");
        int magicNumber2 = int.Parse(Console.ReadLine());
        Console.Write("What is you guess? ");
        int guessedNumber2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Lower");

        Console.Write("What is the magic number? ");
        int magicNumber3 = int.Parse(Console.ReadLine());
        Console.Write("What is you guess? ");
        int guessedNumber3 = int.Parse(Console.ReadLine());
        Console.WriteLine("You guessed it!");

        //  For Parts 2, where the user is asked for the initial magic number followed by guesses:
        Console.Write("What is the magic number? ");
        int magicNumberLoop1 = int.Parse(Console.ReadLine());
        Console.Write("What is you guess? ");
        int guessedNumberLoop1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Higher");

        Console.Write("What is you guess? ");
        int guessedNumberLoop2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Higher");

        Console.Write("What is you guess? ");
        int guessedNumberLoop3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Higher");

        Console.Write("What is you guess? ");
        int guessedNumberLoop4 = int.Parse(Console.ReadLine());
        Console.WriteLine("Lower");

        Console.Write("What is you guess? ");
        int guessedNumberLoop5 = int.Parse(Console.ReadLine());
        Console.WriteLine("Lower");

        Console.Write("What is you guess? ");
        int guessedNumberLoop6 = int.Parse(Console.ReadLine());
        Console.WriteLine("You guessed it!");

         // For Part 3, where we use a random generated number:
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // We could also use a do-while loop here...
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }                    
    }
}