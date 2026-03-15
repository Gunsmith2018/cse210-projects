using System.IO;
public class Journal
{

    public string _entries;

    public Journal(string Entry) // Constructor
    {
        _entries = Entry;
    }

    public void AddEntry(Entry newEntry)
    {
        // This function is going to need a while loop with a quit key.
        // This function will need to grab from the prompt class so the user can think on what to type
        Console.WriteLine("Do you want a prompt or no? (yes/no)");
        string choice = Console.ReadLine().ToLower();

        if(choice == "yes") // sees if the user wants a prompt or not
        {
            Console.WriteLine($"You have selected {choice}. A prompt will appear in 3 seconds.");
            for( int i =0; i<3; i++) // Simulates loading for 3 
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            string prompt = PromptGenerator.GetRandomPrompt();
            Console.WriteLine(prompt);
        }
        else
        {
            Console.WriteLine($"You typed {choice.ToUpper()} for a prompt.");
            for (int i =0; i<3; i++) // Simulates loading for 3
            {
                Console.Write(".");
                Thread.Sleep(1000); // Adjust this for longer or shorter waiting. 
            }
            Console.WriteLine("Please type your entry: ");
            Console.WriteLine("");
            string input = Console.ReadLine();
            _entries = input;

        }
    }
    public void SaveToFile(string file)
    {

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_entries);

        }
    }
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            Console.WriteLine("FILE FOUND");

            _entries = File.ReadAllText(file);
        }
        else
        {
            Console.WriteLine("Sorry, File does not exist.");
        }

    }

    public void DisplayAll()
    {
        Console.WriteLine(_entries);
    }
}