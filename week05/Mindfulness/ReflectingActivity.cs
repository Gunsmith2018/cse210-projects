public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration) // constructor for both ReflectingActivity and calling Activity
    {
        _prompts = new List<string> // Hard Coded prompts and questions. These could be in a library where the user can add more if wanted. 
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



    public void Run() // Run function to be called
    {
        DisplayStartingMessage();

        Console.WriteLine(_description); // The user should be setting the timer for x amount of seconds
        Console.WriteLine();

        Console.WriteLine("Get ready");
        ShowSpinner(3); // Runs the spinner animation from activity class

        string prompt = GetRandomPrompt();//gives the user a prompt
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("When you are ready, press enter.");
        Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Ponder the question below then beguin typing. ");
        ShowSpinner(3);
        Console.WriteLine();


        DateTime startTime = DateTime.Now; // used for handling time effects
        DateTime futureTime = startTime.AddSeconds(_duration);

        do
        {
            string question = GetRandomQuestion();// gives the user a question
            Console.WriteLine(question);
            ShowSpinner(15);

            Console.WriteLine(); // buffer
            Console.Clear();

            Console.WriteLine("Beguin Typing:");
            Console.WriteLine(); // The user is allowd to type without a spinner in the way.
            Console.ReadLine();



        } while (DateTime.Now < futureTime);
        Console.WriteLine("Time is up");
        DisplayEndingMessage();
        ShowSpinner(3);
    }


}