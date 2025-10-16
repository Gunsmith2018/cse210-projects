public class EternalGoal : Goal
{
    public EternalGoal(string shortname, string description, int points) : base(shortname, description, points)
    {

    }
    public override int RecordEvent()
    {
        Console.WriteLine($"Great job! You completed '{_shortName}' and earned {_points} points!");
        return _points;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}