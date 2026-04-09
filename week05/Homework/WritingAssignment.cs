public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string Topic, string title) : base(studentName, Topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_studentName} - {_title}";
    }
}