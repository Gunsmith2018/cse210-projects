using System;
using System.Collections.Generic;
using System.Threading;

public class Listing : Activity
{
    private static readonly List<string> Prompts = new()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt peace this month?",
        "Who are some of your personal heroes?"
    };

    public Listing() 
        : base("Listing Activity", 
               "\nThis activity will help you reflect on the good things in your life by having you list as many things as you can.\n")
    {
    }

    protected override void PerformActivity()
    {
        Random rand = new();
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($"--- {Prompts[rand.Next(Prompts.Count)]} ---");
        Console.WriteLine("You may begin listing in:");
        Countdown(3);

        List<string> items = new();
        int duration = GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                items.Add(input);
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");
    }
}