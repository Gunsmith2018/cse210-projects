using System;

// I have exceeded the requirements
// Instead of retaining straight to the main menu,
// I have added a prompt for the user to press Enter to return to the menu after completing an activity.
// For the breathing activity, I have displayed the countdown as 3 2 1.
// Displaying a goodbye message when the user chooses to quit.


class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("    1. Start Breathing Activity");
            Console.WriteLine("    2. Start Reflection Activity");
            Console.WriteLine("    3. Start Listing Activity");
            Console.WriteLine("    4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new Listing(),
                "4" => null,
                _ => null
            };

            if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            if (activity != null)
            {
                activity.Start();
                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to try again.");
                Console.ReadLine();
            }
        }
    }
}