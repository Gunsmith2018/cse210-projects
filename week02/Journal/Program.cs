using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();

        string choice;

        do
        {
            Console.WriteLine("====================== Welcome to Journal (Main Menu)==========================");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit");
            Console.Write("Choose and option from 1-5");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.AddEntry(generator);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;
                
                case "3":
                    Console.Write("Enter a filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved. ");
                    break;

                case "4":
                    Console.Write("Enter the name of the file you want to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                
                case "5":
                    Console.WriteLine("GoodBye");
                    break;
                default:
                    Console.WriteLine("Please input a valid choice. 1-5: ");
                    break;
            }
        } while (choice != "5");
    }
}