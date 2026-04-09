using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Beta Bob", "Division");
        Console.WriteLine(a1.GetSummary());
        Console.Clear();
        WritingAssignment w1 = new WritingAssignment("Beta Bob", "Writing", "Civil War");
        Console.WriteLine($"{w1.GetSummary()} {w1.GetWritingInformation()}");
    }
}