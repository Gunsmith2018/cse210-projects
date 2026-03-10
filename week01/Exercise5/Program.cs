using System;

class Program
{
    static void Main(string[] args)
    {
    // Variables and string creation
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResults(userName, squaredNumber);

        void DisplayWelcomeMessage() // Welcome Function
        {
            Console.WriteLine("Wellcome to a simple squaring program.");

        }

        static string PromptUserName() // Prompting the user for their name function
        {
            Console.Write("Please tell me your name");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber() // Prompting the user for a number function
        {
            Console.WriteLine("Please give me a number to be squared");
            int number = int.Parse(Console.ReadLine());

            return number;
        }
            
        static int SquareNumber(int number) // Math function set up for squaring the user's number
        {
            int square = number * number;
            return square;
        }
        
        static void DisplayResults(string name, int square) // Displaying the User's name and number Function
        {
            Console.WriteLine($"{name} the square of your number is {square}");
        }
    }
}