using System.IO;

class Program
{
    private string TitleArt = "=== Journal Beta ===";
    private Journal journal = new Journal();
static void Main(string[] args)
    {
        Program program = new Program();
        program.Run(); // This will start the menu and flow
    }


    public void Run()
    {
        bool running = true;
        while (running)
        {
            string choice = GetChoice();
            switch (choice)
            {
                case "1":
                    journal.ReadJournal();
                    break;
                case "2":
                    journal.ClearJournal();
                    break;
                case "3":
                    journal.AddToJournal(); // 👈 Uses Entry.cs with PromptGenerator
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1–4.");
                    break;
            }
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }


    private string GetChoice()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(TitleArt);
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("\nWhat would you like to do?");
        Console.WriteLine(" > 1 - Read journal.");
        Console.WriteLine(" > 2 - Clear journal");
        Console.WriteLine(" > 3 - Add to journal");
        Console.WriteLine(" > 4 - Close journal");

        return Console.ReadLine(); // Get user input
    }

}
