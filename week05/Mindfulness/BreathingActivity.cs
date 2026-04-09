public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.WriteLine("Get ready");
        ShowSpinner(3);

        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in");
            ShowCountDown(4);

            Console.Write("Breathe Out");
            ShowCountDown(6);

            Console.WriteLine();

        }
        DisplayEndingMessage();
        ShowSpinner(3);



    }






}