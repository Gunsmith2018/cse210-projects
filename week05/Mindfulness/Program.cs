using System;

class Program
{
    static void Main(string[] args)
    {

        // loading classes to be accessed
        BreathingActivity breathing = new BreathingActivity("Breating Activity", "This activity will help you with your breathing.", 0);
        ListingActivity listing = new ListingActivity("Listing Activity", "This activity you will be given a prompt then you will type", 0);
        ReflectingActivity reflecting = new ReflectingActivity("Reflecting Activity", "This activity will show you a prompt to start your thinking, then you will be given a question to write a reply.", 0);
  
        string choice;
        do
        {
            Console.WriteLine("====================== Welcome to Mindulness APP (Main Menu)==========================");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose and option from 1-5");

  
            choice = Console.ReadLine();

            switch (choice) // used for having the options be usable
            {
                case "1":
                    breathing.Run();
                    break;

                case "2":
                    listing.Run();
                    break;

                case "3":
                    reflecting.Run();
                    break;

                case "4":
                    break;
                
            }
        } while (choice != "4");
    }
}