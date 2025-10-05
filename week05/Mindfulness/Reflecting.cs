using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private static readonly List<string> Prompts = new()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly List<string> Questions = new()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() 
        : base("Reflection Activity", 
               "\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n")
    {
    }

    protected override void PerformActivity()
    {
        Random rand = new();

        // Step 1: Show prompt
        string prompt = Prompts[rand.Next(Prompts.Count)];
        Console.WriteLine("\nConsider the following prompt: ");
        Console.WriteLine($"\n--- {prompt} ---");

        // Step 2: Ask user to press Enter when ready
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        // Step 3: Transition message and countdown
        Console.WriteLine("Now ponder the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        Countdown(4);

        // Step 4: Show questions one by one for the duration
        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            string question = Questions[rand.Next(Questions.Count)];
            Console.WriteLine($"\n> {question}");
            ShowSpinner(5);
            elapsed += 5;
        }
    }
}