// using System;

// class Program
// {
//     static void Main(string[] args)
//     {   // Display a welocme message:
//         Console.WriteLine("Welocme to the Journal Program!");

//         // Display a menu for the user:
//         Console.WriteLine("Please select one of the following choice: ");
//         Console.WriteLine("1. Write");
//         Console.WriteLine("2. Display");
//         Console.WriteLine("3. Load");
//         Console.WriteLine("4. Save");
//         Console.WriteLine("5. Quit");
//         Console.WriteLine("What would you like to do? ");


//         // Create An Object That Is An Instance
//         //  Of The Entry Class:
//         Entry myEntry = new Entry("What made you happy today?", "I enjoyed a walk on the beach.");

//         // Call The Display Method Of The Entry
//         //  Class To Check If IT Works As
//         //  Expected:
//         myEntry.Display();

//         // Create An Object That Is An Instance
//         //  Of The Journal Class:
//         Journal myJournal = new Journal();

//         // Create Some Entry Objects:
//         Entry entry1 = new Entry("Who was the most interesting person I interacted with today?", "My friend Alpha.");
//         Entry entry2 = new Entry("What was the best part of my day?", "Having Lunch.");

//         // Add These Entries To The Journal:
//         myJournal.AddEntry(entry1);
//         myJournal.AddEntry(entry2);

//         // Call The Display Method Of The Entry
//         //  Class To Check If IT Works As
//         //  Expected:
//         Console.WriteLine("\nDisplay Entries:");
//         myJournal.DisplayAll();

//         // Save To File:
//         myJournal.SaveToFile("journal.txt");

//         // Load From File:
//         Journal loadedJournal = new Journal();
//         loadedJournal.LoadfromFile("journal.txt");

//         // Call The Display Method Again Of The
//         //  Entry Class To Check If IT Works As
//         //  Expected:
//         Console.WriteLine("\nDisplaying Loaded Entries:");
//         loadedJournal.DisplayAll();

//         // Create An Instance Of The
//         // PromptGenerator Class:
//         PromptGenerator promptGenerator = new PromptGenerator();

//         // Get A Random Prompt:
//         string randomPrompt = promptGenerator.GetRandomPrompt();

//         // Display the random prompt:
//         Console.WriteLine($"Random Prompt: {randomPrompt}");

//     }
// }

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Objects of the Journal and Prompt
        //  Generator Classes And Instantiates Them:
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        
        // Use A While To Keep Asking The User For A Choice Until The User Choices To Quit:
        while (true)
        {
            // Displays Instructions For The User:
            Console.WriteLine("Welocme to the Journal Program!");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            // Ask The User For An Input and Read It:
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    myJournal.AddEntry(new Entry(prompt, response));
                    break;

                case "2":
                    myJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter a filename to save to: ");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter a filename to load from: ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile);
                    break;

                case "5":
                    Console.WriteLine("Exiting program. Goodbye!");
                    return; // Exit the program

                default:
                    Console.WriteLine("Invalid option. Please choose a number from 1-5.");
                    break;
            }
        }
    }
}
