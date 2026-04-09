public class ListingActivity  : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you helped someone in need.",
            "Recall a moment when you overcame a challenge.",
            "Think of a time when you felt truly proud of yourself.",
            "Remember a moment when someone showed kindness to you."
        };
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
    public List<string> GetListFromUser()
    {
        List<string> user_list = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        do
        {
            Console.Write(">");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                user_list.Add(input);
            }
        } while (DateTime.Now < endTime);

        return user_list;
    
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.WriteLine("Get ready");
        ShowSpinner(3);

        string prompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("When you are ready, press enter. You will have 15 seconds to ponder.");
        Console.ReadLine();
        ShowSpinner(15);
        Console.WriteLine();

        List<string> responses = GetListFromUser();

        _count = responses.Count;

        Console.WriteLine($"Your listed {_count} items");

        DisplayEndingMessage();
        ShowSpinner(3);
    }
}