public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you helped someone in need.",
            "Recall a moment when you overcame a challenge.",
            "Think of a time when you felt truly proud of yourself.",
            "Remember a moment when someone showed kindness to you."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "What did you learn from it?",
            "How did this experience change you?",
            "How can you apply this lesson today?",
            "What emotions did you feel during that moment?"
        };
    }


    public string GetRandomPrompt() // The get display method felt extra so it was removed and the idea will be used in run
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    
    public string GetRandomQuestion() // The get display method felt extra so it was removed and the idea will be used in run
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
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
        Console.WriteLine("When you are ready, press enter.");
        Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Ponder the question below then beguin typing. ");
        ShowSpinner(3);
        Console.WriteLine();


        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        do
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);
            ShowSpinner(15);
            Console.WriteLine();

            Console.WriteLine("Beguin typing: ");
            Console.WriteLine("");
            Console.ReadLine();


        } while (DateTime.Now < endTime);
        Console.WriteLine("Time is up");
        DisplayEndingMessage();
        ShowSpinner(3);
    }


}