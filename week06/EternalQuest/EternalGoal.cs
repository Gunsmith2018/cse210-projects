public class EternalGoal : Goal
{
    public EternalGoal(string shortname, string description, int points) : base(shortname, description, points)
    {

    }
    public void RecordEvent()
    {
        Console.WriteLine($"Great job! You completed '{_shortName}' and earned {_points} points!");
        return _points; 
    }
    public bool IsComplete()
    {
        return false;
    }
    public string GetStringRRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}