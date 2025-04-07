using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            // Menu system
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("Select an activity to do:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            string choice = Console.ReadLine();
            int duration;

            // Get the duration of activity from the user
            Console.Write("Enter duration (in seconds): ");
            duration = Convert.ToInt32(Console.ReadLine());

            // Create the activity based on user choice
            Activity activity = null;
            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity(duration);
                    break;
                case "2":
                    activity = new ReflectingActivity(duration);
                    break;
                case "3":
                    activity = new ListingActivity(duration);
                    break;
                case "4":
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    continue;
            }

            // Run the selected activity
            if (activity != null)
            {
                if (activity is BreathingActivity breathingActivity)
                    breathingActivity.Run();
                else if (activity is ReflectingActivity reflectingActivity)
                    reflectingActivity.Run();
                else if (activity is ListingActivity listeningActivity)
                    listeningActivity.Run();
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
