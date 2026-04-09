public class Assignment
{
    protected string _studentName;
    protected string _topic;

    public Assignment(string studentName, string Topic)
    {
        _studentName = studentName;
        _topic = Topic;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

}