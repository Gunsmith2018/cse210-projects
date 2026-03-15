using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");
                    for (int i =0; i<3; i++) // Simulates loading for 3
            {
                Console.Write(".");
                Thread.Sleep(1000); // Adjust this for longer or shorter waiting. 
            }
    }
}