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
