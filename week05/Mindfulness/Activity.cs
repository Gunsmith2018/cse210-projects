public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine("Welcome to the Mindfullness app");
    }
    
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed {_name} within {_duration}");
    }

    public void ShowSpinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        while(DateTime.Now < endTime)
        {
            Console.Write(frames[index]);
            Thread.Sleep(100);
            Console.Write("\b");
            index = (index + 1) % frames.Length;
        }
    }
    
    public void ShowCountDown(int seconds)
    {
        for(int i = seconds; i > 0; i --)
        {
            Console.Write(i);
            Thread.Sleep(100);
            Console.Write("\b \b");
        }
    }








}
