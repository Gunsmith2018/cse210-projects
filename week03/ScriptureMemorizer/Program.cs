using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private string _titleArt = "=== Scripture Memorizer ===";
    private Scripture _currentScripture;
    private string[] _scriptureStrings = new string[]
    {
        "John 3:16~For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.",
        "Proverbs 3:5-6~Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.",
        "1Nephi 3:7~And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
    };

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    public void Run()
    {
        bool running = true;
        
        while (running)
        {
            Console.Clear();
            Console.WriteLine(_titleArt);
            Console.WriteLine("1. Start New Scripture");
            Console.WriteLine("2. Continue Current Scripture");
            Console.WriteLine("3. Exit");
            Console.Write("Select an option: ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    StartNewScripture();
                    break;
                case "2":
                    ContinueScripture();
                    break;
                case "3":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Press Enter to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    private void StartNewScripture()
    {
        string randomScripture = GetRandomScripture();
        string[] parts = randomScripture.Split('~');
        string referenceText = parts[0];
        string scriptureText = parts[1];
        
        Reference reference = ParseReference(referenceText);
        _currentScripture = new Scripture(reference, scriptureText);
        
        RunMemorization();
    }

    private void ContinueScripture()
    {
        if (_currentScripture == null)
        {
            Console.WriteLine("No scripture loaded. Please start a new one.");
            Console.ReadLine();
            return;
        }
        
        if (_currentScripture.IsCompletelyHidden())
        {
            Console.WriteLine("Current scripture is completely memorized! Start a new one.");
            Console.ReadLine();
            return;
        }
        
        RunMemorization();
    }

    private void RunMemorization()
    {
        while (!_currentScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(_currentScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'menu' to return to menu:");
            
            string input = Console.ReadLine();
            if (input.ToLower() == "menu") return;
            
            _currentScripture.HideRandomWords(3);
        }
        
        if (_currentScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(_currentScripture.GetDisplayText());
            Console.WriteLine("\nCongratulations! You've memorized the scripture!");
            Console.WriteLine("Press Enter to return to menu.");
            Console.ReadLine();
        }
    }

    private string GetRandomScripture()
    {
        Random rand = new Random();
        return _scriptureStrings[rand.Next(_scriptureStrings.Length)];
    }

    private Reference ParseReference(string referenceText)
    {
        string[] parts = referenceText.Split(' ');
        string book = parts[0];
        string chapterVerse = parts[1];
        
        if (chapterVerse.Contains('-'))
        {
            string[] chapterAndVerses = chapterVerse.Split(':');
            int chapter = int.Parse(chapterAndVerses[0]);
            string[] verses = chapterAndVerses[1].Split('-');
            int startVerse = int.Parse(verses[0]);
            int endVerse = int.Parse(verses[1]);
            
            return new Reference(book, chapter, startVerse, endVerse);
        }
        else
        {
            string[] chapterAndVerse = chapterVerse.Split(':');
            int chapter = int.Parse(chapterAndVerse[0]);
            int verse = int.Parse(chapterAndVerse[1]);
            
            return new Reference(book, chapter, verse);
        }
    }
}