using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary(); // This is a added class

        // adding to the new ScruitureLibrary
        library.AddScriptures(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son"
        ));

        library.AddScriptures(new Scripture(
            new Reference("2 Nephi", 31, 20),
            "Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life."
        ));

        library.AddScriptures(new Scripture(
            new Reference("James", 1, 5, 6),
            "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed."
        ));

        // To add more, just copy
        /*
        library.AddScriptures(new Scripture(
            new Reference("BOOK", CHAPTER, VERSE),
            "Type scripture here"
        ));
        */

        Scripture script = library.GetRandomScripture();

        // Welcome message //
        Console.Clear();
        Console.WriteLine("===============Welcome to Scripture Mastery=================");
        Console.Write("How many words would you like to hide each time? ");
        int amount = int.Parse(Console.ReadLine()); // these two lines allow for the user to decide how many words are hidden

        // looping so the program runs
        do
        {
            Console.Clear();
            Console.WriteLine(script.GetDisplayText());

            Console.WriteLine("\nType the scripture exactly as you remember it:");
            string userInput = Console.ReadLine();

            string actualText = script.GetFullText();

            // Compare user input to original scripture
            if (!string.Equals(userInput.Trim(), actualText.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nPlease try again.");
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                continue; // restart the loop without hiding words
            }

            Console.WriteLine("\nCorrect! Press Enter to hide words or type 'quit' to leave.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            script.HideRandomWords(amount); // This could be changed to be a hard coded number or set up to have the computer decide (RNG)

            if (script.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(script.GetDisplayText());
                Console.WriteLine("\nAll words are hidden!");
                break;
            }

        } while (true);
    }
}