public class Journal
{
    public void AddToJournal()
    {
        Prompts generator = new Prompts();
        Console.WriteLine(generator.GetRandomPrompt());
        Console.WriteLine("Enter your Journal Entry: ");

        string entryText = Console.ReadLine();

        string timestamp = DateTime.Now.ToString("MM/dd/yyyy"); // Automatically sets the current Date
        string firmattedEntry = $"Date: {timestamp}\nEntry: {entryText}\n---\n";

        File.AppendAllText("journal.txt", firmattedEntry + Environment.NewLine);
        Console.WriteLine("Saved Entry");

    }
    public void ReadJournal()
    {
        if (File.Exists("journal.txt"))
        {
            string[] entries = File.ReadAllLines("journal.txt");
            Console.WriteLine("Your Journal Entries:\n" + string.Join("\n", entries));

        }
        else
        {
            Console.WriteLine("No journal entries found.");
        }
    }
    public void ClearJournal()
    {
        if (File.Exists("journal.txt"))
        {
            File.Delete("journal.txt");
            Console.WriteLine("Journal Deleted");
        }
        else
        {
            Console.WriteLine("No journal to delete.");
        }
    }
}