public class Prompts
{
    private string[] _prompts = new string[]
    {
        "What made you smile today?",
        "Describe a moment you felt proud.",
        "What do you want to achieve this week?",
        "What’s something you’re grateful for right now?",
        "What’s a challenge you overcame recently?"
    };



    public Prompts() {}
    public Prompts(string[] prompts)// Constructor to initialize with custom prompts
    {
        _prompts = prompts;
    }

    public string GetRandomPrompt()// Random Prompt Generator
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Length);
        return _prompts[index];
    }



}