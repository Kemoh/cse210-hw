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
