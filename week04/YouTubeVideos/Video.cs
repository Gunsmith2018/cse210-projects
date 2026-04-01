public class Video
{
    private string _title;
    private string _author;
    private int _length;
   private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

public int GetCommentCount()
    {
        return _comments.Count;
    }



    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Comment: {GetCommentCount()}");
        Console.WriteLine($"Length: {_length}");

        foreach (Comment c in _comments)
        {
            Console.WriteLine($"- {c.GetName()}: {c.GetText()}");
        }
        Console.WriteLine();
    }
}