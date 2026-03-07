using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        int a = 90;
        int b = 80;
        int c = 70;
        int d = 60;
        int f = 50;

        Console.Write("Please tell me what percent you got on your grade: ");
        string input = Console.ReadLine();
        int percent;
        if (int.TryParse(input, out percent) )
        {
            if (percent >= a)
            Console.WriteLine("Congragulations. That is an A: ");
            if (percent >= b)
            Console.WriteLine("Congragulations. That is an b: ");
            if (percent >= c)
            Console.WriteLine("Congragulations. That is an c: ");
            if (percent >= d)
            Console.WriteLine("Unfortantly, that is a failing: D");
            if (percent >= f)
            Console.WriteLine("Unfortanatly, that is failing: F");
        }
    }
}