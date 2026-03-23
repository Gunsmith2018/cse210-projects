public class Word
{
    private string _text;
    private bool _isHidden; // default to false

    public Word(string Text) // constructor
    {
        _text = Text;
    }

    public void Hide() // Indirectly a setter
    {
        _isHidden = true; // switches from false to true
    }
    public void Show()// Indirectly a setter
    {
        _isHidden = false;
    }
    public bool IsHidden()// Indirectly a Getter
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string( '_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
    public string GetOriginalText()
    {
        return _text; 
    }
}