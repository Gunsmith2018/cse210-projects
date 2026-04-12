using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public GoalManager()
    {

    }


    public void start() // Runs the program
    {
        {
            string choice;

            do
            {
                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");

                Console.Write("Select a choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateGoal();
                        break;

                    case "2":
                        ListGoalNames();
                        break;

                    case "3":
                        SaveGoals();
                        break;

                    case "4":
                        LoadGoals();
                        break;

                    case "5":
                        RecordEvent();
                        break;

                    case "6":
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            } while (choice != "6");
        }
    }

    public void DisplayPlayerInfo() // displays the player's info
    {
        Console.WriteLine();
    }

    public void ListGoalNames() // listing the name of each goal
    {
        Console.WriteLine("Your Goals: ");
        int index = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetName()}");
            index++;
        }
    }

    public void ListGoalDetails()// listing the details of each goal
    {
        Console.WriteLine("Goal Details: ");

        int index = 0;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }
    }

    public void CreateGoal() // Menu options and ways for the user to create goals
    {
        Console.WriteLine("What goal are you looking to create or do you want to see goal checklist?");
        Console.WriteLine("Simple Goal: 1  ");
        Console.WriteLine("Eternal Goal: 2 ");
        Console.WriteLine("Checklist: 3 ");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Please tell me your simple goals name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please give me a short description of your goal: ");
            string description = Console.ReadLine();
            Console.WriteLine("Please tell me how many points this will be worth: ");
            string points = Console.ReadLine();

            SimpleGoal simple = new SimpleGoal(name, description, points);

            _goals.Add(simple);


        }
        else if (choice == "2")
        {
            Console.WriteLine("What is your Eternal goal: ");
            string name = Console.ReadLine();
            Console.WriteLine("what is the short description of the goal?");
            string description = Console.ReadLine();
            Console.WriteLine("What is the points for this? Do note this may never be completed;");
            string points = Console.ReadLine();

            EternalGoal eternal = new EternalGoal(name, description, points);

            _goals.Add(eternal);
        }
        else if (choice == "3")
        {
            Console.WriteLine("What is the name for this check list goal: ");
            string name = Console.ReadLine();
            Console.WriteLine("What is the description for this goal: ");
            string description = Console.ReadLine();
            Console.WriteLine("What is the base points for this goal: ");
            string points = Console.ReadLine();
            Console.WriteLine("How many times do you want to complete this goal: ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("What are the bonus points for completing this goal's target: ");
            int bonus = int.Parse(Console.ReadLine());
            int amountCompleted = 0;

            ChecklistGoal checklist = new ChecklistGoal(name, description, points, amountCompleted, target, bonus);

            _goals.Add(checklist);

        }

    }

    public void RecordEvent() // Uesed for checking if the User has completed a goal and rewards points to the user.
    {


        Console.Write($"Here are your goals: ");
        ListGoalNames();

        Console.WriteLine("Which Goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        Goal selectedGoal = _goals[choice - 1];

        selectedGoal.RecordEvent();

        int points = int.Parse(selectedGoal.GetPoints());
        _score += points;

        // 4. Tell the user what they earned
        Console.WriteLine($"Congratulations! You earned {points} points!");
        Console.WriteLine($"Your new total score is: {_score}");

    }
    public void SaveGoals() // wrapper for saving
    {
        Console.Write("Enter the filename to save to: ");
        string file = Console.ReadLine();
        SaveGoals(file);
    }
    public void SaveGoals(string file) // saving method
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals() // load wrapper
    {
        Console.Write("Enter the filename to load from: ");
        string file = Console.ReadLine();
        LoadGoals(file);
    }
    public void LoadGoals(string file) //loading method
    {
if (!File.Exists(file))
    {
        Console.WriteLine("File not found.");
        return;
    }

    string[] lines = File.ReadAllLines(file);

    _goals.Clear();

    if (lines.Length == 0)
    {
        Console.WriteLine("File is empty.");
        return;
    }

    // First line is the score
    _score = int.Parse(lines[0]);

    // Remaining lines are goals
    for (int i = 1; i < lines.Length; i++)
    {
        string line = lines[i];
        string[] parts = line.Split(':');      // Type : data
        string type = parts[0];
        string[] data = parts[1].Split(',');   // fields

        if (type == "SimpleGoal")
        {
            string name = data[0];
            string description = data[1];
            string points = data[2];
            bool isComplete = bool.Parse(data[3]);

            SimpleGoal g = new SimpleGoal(name, description, points);
            if (isComplete)
            {
                g.RecordEvent(); // or set a property if you have one
            }
            _goals.Add(g);
        }
        else if (type == "EternalGoal")
        {
            string name = data[0];
            string description = data[1];
            string points = data[2];

            EternalGoal g = new EternalGoal(name, description, points);
            _goals.Add(g);
        }
        else if (type == "ChecklistGoal")
        {
            string name = data[0];
            string description = data[1];
            string points = data[2];
            int amountCompleted = int.Parse(data[3]);
            int target = int.Parse(data[4]);
            int bonus = int.Parse(data[5]);

            ChecklistGoal g = new ChecklistGoal(name, description, points, amountCompleted, target, bonus);
            _goals.Add(g);
        }
    }

    Console.WriteLine("Goals loaded successfully.");
}

    }
