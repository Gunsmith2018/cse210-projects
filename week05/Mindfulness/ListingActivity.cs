public class ListingActivity  : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)// constructor for both ReflectingActivity and calling Activity
    {
        _prompts = new List<string> // Prompts could be put in a library of its own 
        {
            "Think of a time when you helped someone in need.",
            "Recall a moment when you overcame a challenge.",
            "Think of a time when you felt truly proud of yourself.",
            "Remember a moment when someone showed kindness to you."
        };
    }

    public string GetRandomPrompt() // random prompt decider
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
    public List<string> GetListFromUser() // creating a list from the user's inputs
    {
        List<string> user_list = new List<string>();

        DateTime startTime = DateTime.Now; // used for handling time effects
        DateTime futureTime = startTime.AddSeconds(_duration);

        do // creating user list
        {
            Console.Write(">");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                user_list.Add(input);
            }
        } while (DateTime.Now < futureTime);

        return user_list;

    }
    
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.WriteLine("Get ready");
        ShowSpinner(3);


        string prompt = GetRandomPrompt(); // Userinteraction
        Console.WriteLine("You will have 15 seconds to ponder before typing.");
        Console.WriteLine($"Prompt: {prompt}");


        Console.WriteLine("Pondering...");
        ShowSpinner(15);
        Console.WriteLine();
        Console.WriteLine("START");
        Console.WriteLine();

        List<string> responses = GetListFromUser();

        _count = responses.Count;

        Console.WriteLine($"Your listed {_count} items");

        DisplayEndingMessage();
        ShowSpinner(3);
    }
}