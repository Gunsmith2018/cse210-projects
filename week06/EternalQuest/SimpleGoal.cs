using System.ComponentModel;

public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortname, string description, int points) : base(shortname, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;  // Return points when the goal is completed
        }
        else 
        {
            Console.WriteLine($"{_shortName} has already been completed. No points will be rewarded.");
            return 0;  // No points if already completed
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}

