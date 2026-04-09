using System;
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine(_description); // The user should be setting the timer for x amount of seconds
        Console.WriteLine();

        Console.WriteLine("Get ready"); // Signals the user to get ready
        ShowSpinner(3);
        Console.WriteLine();
 
        DateTime startTime = DateTime.Now; // used for handling time effects
        DateTime futureTime = startTime.AddSeconds(_duration);



        while (DateTime.Now < futureTime) // runs the program for the amount of time the user wanted
        {
            Console.Clear();
            Console.Write("Breathe in: ");
            ShowCountDown(4); // hardcoded for porgam activity
            Console.Clear();

            Console.Write("Breathe Out: ");
            ShowCountDown(6);// hardcoded for porgam activity
            Console.Clear();

        }

        // displays message before returning to the main menu
        DisplayEndingMessage();
        ShowSpinner(3);



    }

}