using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {

        // variables used for grading
        int a = 90;
        int b = 80;
        int c = 70;
        int d = 60;
        
        int percent; // This will be used for converting the string into an int

        while (true) // While loop used for looping the user untill a valid number is inputed
        {
            Console.WriteLine("Please tell me what percent you got on your grade or type exit to leave: ");
            string input = Console.ReadLine(); // Saving the user input into a string

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Thank you for using a simple grading system.");
                break; // used for leaving a while loop
            }

            if (int.TryParse(input, out percent)) // converting the user's unput into a usable in for "percent"
            {
                    if (percent >= a) // Asking for what grade the user got. Currently set up for only BASE grades no plus or minus yet. 
                    {
                        Console.WriteLine("Congragulations. That is an A: ");
                    }
                    else if (percent >= b)
                    {
                        Console.WriteLine("Congragulations. That is an b: ");
                    }
                    else if (percent >= c)
                    {
                        Console.WriteLine("Congragulations. That is an c: ");
                    }
                    else if (percent >= d)
                    {
                        Console.WriteLine("Unfortantly, that is a failing: D");
                    }
                    else 
                    {
                        Console.WriteLine("Unfortanatly, that is failing: F");
                    }
                break; // used for leaving a while loop
            }
            else // Crash out condition for when the User doesn't input a valid number
            {
                Console.WriteLine("Sorry, you have entered a invalid number. Please enter a valid number: ");
            }
        }
    }
}