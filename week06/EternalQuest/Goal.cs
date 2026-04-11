public class Goal
{
    private string _shortname; 
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortname = name;
        _description = description;
        _points = points;
    } 



    public void RecordEvent()
    {
        
    }
    public bool IsComplete()
    {
        return true;
    }
    public string GetDetailsString()
    {
        return;
    }
    public string GetStringRepresentation()
    {
        return;
    }
}