using System;

class Program
{
    static void Main(string[] args)
    {

        // Random Number Generator
        Random  randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        for (int guess = -1; guess != number;) // Checks that the User input isn't equal to the "magic" number
        {
            Console.Write("Guess a number between 1 and 100: ");
            Console.WriteLine("===================================="); // spacer
            string input = Console.ReadLine();

            if (int.TryParse(input, out guess)) // converts string into a usable int format
            {
                if (guess > number)
                {
                    Console.WriteLine("Your guess is too HIGH, try LOWER: ");
                    Console.WriteLine("===================================="); //spacer
                }
                else if (guess < number)
                {
                    Console.WriteLine("Your guess is too LOW, try Higher: ");
                    Console.WriteLine("===================================="); // spacer
                }

            }
            else
            {
                Console.WriteLine("Invalid input. Please try again with a valid number.");
                Console.WriteLine("===================================="); // spacer
            }
        }
        Console.WriteLine("Congratulations! You got it.");
        Console.WriteLine("===================================="); // spacer
    }
}