using System;
public abstract class Goal // This parent class is an abstract class. The child classes will implement the abstract methods.
{
    protected string _shortName;
    protected string _description;
    protected int _points; // might need to change this to a string later


    public Goal(string shortname, string description, int points)
    {
        _shortName = shortname;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public string GetDetailsString()
    {
          string checkbox = IsComplete() ? "[X]" : "[ ]";
          return $"{checkbox} {_shortName} ({_description})";
    }
    

}