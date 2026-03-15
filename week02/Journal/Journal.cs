using System.IO;
public class Journal
{

    public List<string> _entries = new List<string>();

    public Journal(List<string> Entry)
    {
        _entries = Entry;
    }

    public void AddEntry(Entry newEntry)
    {

    }
    public void SaveToFile(string file)
    {
        Console.WriteLine(" Entry: ");
        _entries = Console.ReadLine();
    }
    public void LoadFromFile(string file)
    {
        if (File.Exists("Journal.txt"))
        {
            string[] lines = File.ReadAllLines("Journal.txt"); // loading(reads) in Journal.txt           
            foreach (string ln in lines)
                Console.WriteLine(ln);
        }

    }

    public void DisplayAll()
    {

    }
}