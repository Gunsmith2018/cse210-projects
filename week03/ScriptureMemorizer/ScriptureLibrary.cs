/*
The purpose of this added class
is to store the scripture that is added 
through Program.cs. I wanted to have multiple scriptures
that the user has to memorize rather than just one constantly 
show up. 
*/

public class ScriptureLibrary
{
    private List<Scripture> _scriptures = new List<Scripture>();
    private Random _rand = new Random();

    public void AddScriptures(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }
    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
        {
            throw new Exception("No Scriptures in the Library. ");
        }

        int index = _rand.Next(_scriptures.Count);
        return _scriptures[index];
    }



















}