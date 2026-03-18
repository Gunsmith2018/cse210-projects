using System.IO;
public class Journal
{

    public List<Entry> _entries = new List<Entry>();

    public Journal() { } // keeps the lists defaults

    public Journal(List<Entry> entries) // Constructor
    {
        _entries = entries;
    }

    public void AddEntry(PromptGenerator generator)
    {
        Console.WriteLine("Do you want a prompt or no? (yes/no)");
        string choice = Console.ReadLine().ToLower();
        string prompt = "";

        if(choice == "yes") // sees if the user wants a prompt or not
        {
            Console.WriteLine($"You have selected {choice.ToUpper()}. A prompt will appear in 3 seconds.");
            for (int i = 0; i < 3; i++) // Simulates loading for 3 
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();

            prompt = generator.GetRandomPrompt();
            Console.WriteLine(prompt);

            Console.WriteLine("Please type your entry: "); // taking user's input
            string text = Console.ReadLine();
            string date = DateTime.Now.ToShortDateString();

            Entry newEntry = new Entry(date, prompt, text);

            _entries.Add(newEntry);
          
        }
        else
        {
            Console.WriteLine($"You typed {choice.ToUpper()} for a prompt.");
            for (int i =0; i<3; i++) // Simulates loading for 3
            {
                Console.Write(".");
                Thread.Sleep(1000); // Adjust this for longer or shorter waiting. 
            }
            Console.WriteLine("Please type your entry: "); // taking user's input
            string text = Console.ReadLine();
            string date = DateTime.Now.ToShortDateString();

            Entry newEntry = new Entry(date, prompt, text);

            _entries.Add(newEntry);


        }
    }
    public void SaveToFile(string file)
    {

        using (StreamWriter outputFile = new StreamWriter(file)) // should be saving to file
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine(entry._promptText);
                outputFile.WriteLine(entry._entryText);
                outputFile.WriteLine("_________");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))// Checking to see if "File" is avalible
        {
            Console.WriteLine("FILE FOUND");
            _entries.Clear();

            string[] lines = File.ReadAllLines(file);
            for( int i = 0; i <lines.Length; i+= 4)
            {
                if (i + 2 >= lines.Length)
                    break;
                string date = lines[i];
                string prompt = lines[i + 1];
                string text = lines[i + 2];

                Entry loadedEntry = new Entry(date, prompt, text);
                _entries.Add(loadedEntry);
            }
        }
        else
        {
            Console.WriteLine("Sorry, File does not exist.");
        }

    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
            }
}