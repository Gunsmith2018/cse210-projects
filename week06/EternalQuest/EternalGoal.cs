public class EternalGoal : Goal
{
    public EternalGoal(string shortname, string description, int points) : base(shortname, description, points)
    {

    }
    public void RecordEvent()
    {
        // Eternal goals are never completed, so no action is needed here.
    }
    public bool IsComplete()
    {

    }
    public string GetStringREpresentation()
    {
        
    }
}