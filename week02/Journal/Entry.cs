public class Entry
{
    private string _date = "";
    private string _promptText = "";
    private string _entryText = "";

 
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void WelcomeMessage()
    {
        Console.WriteLine("Wellcome to JOurnal Beta");

    }



    public string GetPrompt()
    {
        Prompts promptGen = new Prompts();
        string prompt = promptGen.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        return prompt;
    }

    private string GetEntry()
    {
        Console.Write("Please input your thoughts: ");
        return Console.ReadLine();
    }

    public string FromatForSaving()
    {
        return $"Date: {_date}\nPrompt: {_promptText}\nEntry: {_entryText}\n---\n";
    }
}