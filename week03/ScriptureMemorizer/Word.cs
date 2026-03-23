public class Word
{
    private string _text;
    private bool _isHidden; // default to false

    public Word(string Text) // constructor
    {
        _text = Text;
    }

    public void Hide()
    {
        _isHidden = true; // switches from false to true
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        
    }
}