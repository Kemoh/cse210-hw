// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Tests whether the Word program works correctly:
//         // Test cases:
//         Word word1 = new Word("Hello");
//         Word word2 = new Word("Bayohumaru");

//         // Call the display method of the Word class to see if the program works correctly:
//         // At the start of the program, the words should be displayed correctly to the console:
//         Console.WriteLine($"Word 1: {word1.GetDisplayText()}");
//         Console.WriteLine($"Word 2: {word2.GetDisplayText()}");

//         // Let us hide word1 and word2:
//         word1.Hide();
//         word2.Hide();
//         Console.WriteLine($"Word 1 (hidden): {word1.GetDisplayText()}");
//         Console.WriteLine($"Word 2 (hidden): {word2.GetDisplayText()}");

//         // Let us show the hidden words again:
//         word1.Show();
//         word2.Show();
//         Console.WriteLine($"Word 1 (hidden): {word1.GetDisplayText()}");
//         Console.WriteLine($"Word 2 (hidden): {word2.GetDisplayText()}");

//         // Let us hide word1 again and leave word2 visible:
//         word1.Hide();
//         word2.Show();
//         Console.WriteLine($"Word 1 (hidden): {word1.GetDisplayText()}");
//         Console.WriteLine($"Word 2 (hidden): {word2.GetDisplayText()}");

//         // Let us check whether the words are hidden:
//         Console.WriteLine($"Word 1 (hidden): {word1.IsHidden()}");
//         Console.WriteLine($"Word 2 (hidden): {word2.IsHidden()}");

        // Test the Reference Class to check whether
        // it works correctly
        // Create a new instance of the Reference
        //  class
        // Reference reference1 = new Reference("John", 3, 16);
//         Console.WriteLine(reference1.GetDisplayText());

//         Reference reference2 = new Reference("Psalms", 23, 1, 6);
//         Console.WriteLine(reference2.GetDisplayText());

//         //TEST FOR THE SCRIPTURE PROGRAM
//         // Create a reference for the scripture:
//         Reference reference = new Reference("John", 3, 16);

//         // Create a Scripture object with text:
//         string scriptureText = "For God so loved the world that he gave his only Son, that whoever believes in him should not perish but have eternal life.";
//         Scripture scripture = new Scripture(reference, scriptureText);

//         // Display the full scripture with no hidden words:
//         Console.WriteLine("Full Scripture:");
//         Console.WriteLine(scripture.GetDisplayText());

//         // Hide some randon words in the scripture:
//         // Hide 5 random words:
//         scripture.HideRandomWords(5);

//         // Display the scripture with hidden words:
//         Console.WriteLine("\nScripture with Hidden Words:");
//         Console.WriteLine(scripture.GetDisplayText());

//         // Check if the words are completly
//         //  hidden:
//         bool IsCompletelyHidden = scripture.IsCompletelyHidden();
//         Console.WriteLine($"\nIs the scripture completly hidden? {IsCompletelyHidden}");

//     }
// }

// The Main program above was written for testing each of the classes as they were being built.

// Below is the Main program for the Scripture Memorizar Program:


using System;

public class Program
{
    public static void Main()
    {
        // Step 1: Create a Scripture Reference:
        Reference reference = new Reference("Psalms", 23, 1, 6);

        // Step 2: Create the Scripture text:
        string scriptureText = "The Lord is my shepherd; I shall not want. He maketh me to lie down in green pastures: he leadeth me beside the still waters. He restoreth my soul: he leadeth me in the paths of righteousness for his name's sake. Yea, though I walk through the valley of the shadow of death, I will fear no evil: for thou art with me; thy rod and thy staff they comfort me. Thou preparest a table before me in the presence of mine enemies: thou anointest my head with oil; my cup runneth over. Surely goodness and mercy shall follow me all the days of my life: and I will dwell in the house of the Lord for ever.";

        // Step 3: Split the Scripture text in to
        //  words and each word stored as a word
        //  object:
        Scripture scripture = new Scripture(reference, scriptureText);

        // Loop to display the Scripture text each
        //  time and hide words and prompt the user
        //  for an action:
        while (true)
        {
            // Step 4: Clear the console and display
            //  the full scripture
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            // Step 5: Ask the user to press Enter
            //  to hide more words or type 'quit' to
            //  exit
            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                // Step 6: Exit the program if the user types 'quit'
                break;
            }

            // Step 7: Hide 1 random word each time
            //  the user presses Enter
            scripture.HideRandomWords(1);

            // Step 8: If all words are hidden, exit
            //  the loop and end the program
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. The program is ending.");
                break;
            }
        }
    }
}
