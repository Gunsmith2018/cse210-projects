using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
               "\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n")
    {
    }

    protected override void PerformActivity()
    {
        int duration = GetDuration();
        int cycleTime = 6; // seconds per breathe in + out
        int cycles = duration / cycleTime;

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("\nBreathe in... ");
            Countdown(3);
            Console.Write("Breathe out... ");
            Countdown(3);
        }
    }
}