using System.Security.Cryptography;

public class GoalManager
{
    private string TitleArt = "=== Goals  Beta ===";

    private List<Goal> _goals;
    private int _score;

    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals;
        _score = score;
    }
    public void Start()
    {
        Run();
    }


    public void Run()
    {
        bool running = true;
        while (running)
        {
            string choice = GetChoice();
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1–4.");
                    break;
            }
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }


    private string GetChoice()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(TitleArt);
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("\nWhat would you like to do?");
        Console.WriteLine(" > 1 - Create New Goal.");
        Console.WriteLine(" > 2 - List Goal Details");
        Console.WriteLine(" > 3 - Record Event");
        Console.WriteLine(" > 4 - Close Program");

        return Console.ReadLine(); // Get user input
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
        Console.WriteLine($"You have {_goals.Count} goals.");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("\nThe current goals are:");
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("\nYour Current Goals are: ");
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals currently.");
            return;
        }
        else
        {
            int index = 1;
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{index}. {goal.GetDetailsString()}");
                index++;
            }
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("\n What type of goal would you like to create?");

        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        string choice = Console.ReadLine();
        if (choice == "1")
        {
            Console.Write("\nWhat is your Simple goal? ");
            Console.Write("What is the point value? ");
            string pointValue1 = Console.ReadLine();

        }
        else if (choice == "2")
        {
            Console.Write("\nWhat is your Eternal Goal?");
            Console.Write("What is the point value? ");
            string goal2 = Console.ReadLine();
            string pointValue2 = Console.ReadLine();
        }
        else if (choice == "3")
        {
            Console.Write("\n What is your Checklist Goal?");
            Console.Write("What is the point value? ");
            string goal3 = Console.ReadLine();
            string pointValue3 = Console.ReadLine();
        }
    }
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record events for.");
            return;
        }

        // Show the user their goals
        Console.WriteLine("\nYour goals are:");
        ListGoalDetails();

        // Get user selection
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        // Validate choice and record the event
        if (choice >= 0 && choice < _goals.Count)
        {
            int pointsEarned = _goals[choice].RecordEvent();
            _score += pointsEarned;

            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
            Console.WriteLine($"You now have {_score} total points.");
        }
        else
        {
            Console.WriteLine("Invalid goal selection. Please try again.");
        }
    }
    public void SaveGoals()
    {
        Console.Write("What would you like to name your Goal file? ");
        string filename = Console.ReadLine();
        if (!filename.EndsWith(".txt"))
        {
            filename += ".txt";
        }
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.ToString());
            }
        }
        Console.WriteLine($"Goals saved to {filename}");
    }
    public void LoadGoals()
    {
        Console.Write("What file would you like to load?");
        string filename = Console.ReadLine();
        if (!filename.EndsWith(".txt"))
        {
            filename += ".txt";
        }
        if (!File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);
            _goals.Clear();
            Console.WriteLine("Goals loaded successfully.");
        }
        else Console.WriteLine("File not found.");
    }
}