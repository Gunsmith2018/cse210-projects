public abstract class Goal
{
    protected string _shortName; 
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }


    public string GetName() // This is a helper for GoalManager to get GoalNames
    {
        return _shortName;
    }
    public string GetPoints() // Another helper for GoalManager 
    {
        return _points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();


}