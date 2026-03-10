using System;

class Program
{
    static void Main(string[] args)
    {


        List<int> numbers = new List<int>();

        int userNumber = -1;

        while (userNumber != 0) // runs the program as long as the user doesn't type 0
        {
            Console.Write("Please enter some numbers excluding 0, unless you want to exit: ");
            string user = Console.ReadLine();

            if (int.TryParse(user, out userNumber)) // switches the suer input to a int rather than a string
            {
                if (userNumber != 0) // Adds to "numbers" string excluding 0
                {
                    numbers.Add(userNumber);
                }
            }

            int sum = 0;

            foreach (int number in numbers) // adding up the numbers in the string. 
            {
                sum += number;
            }

            Console.WriteLine($"The sum is: {sum}"); // displaying the sum of the string
        }

    }
}