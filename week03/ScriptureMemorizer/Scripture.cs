public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

public Scripture() // default contructor
    {
        
    }
    public Scripture(Reference Reference, string text) // constructor
    {
        _reference = Reference;
        string[] pieces = text.Split(" "); // splits the string into individual words
        foreach (string part in pieces)// turning each piece into a word object
        {
            _words.Add(new Word(part)); 
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random(); // importing random generation
        for (int i =0; i <numberToHide; i++)
        {
            List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();// Calling for a list of words that are not hidden

            if(visibleWords.Count == 0) // if all words are hidden stop checking
            {
                break;
            }
            else
            {
                int index = rand.Next(visibleWords.Count);
                Word chosen = visibleWords[index]; // Deciding a random word to be hidden
                chosen.Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();

        List<string> wordTexts = new List<string>();
        foreach (Word w in _words)
        {
            wordTexts.Add(w.GetDisplayText());
        }
        string scriptureText = string.Join(" ", wordTexts);
        return $"{referenceText}\n{scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())// Plain English: Give me a word that is NOT hidden
            {
                return false;
            }

        }
        return true;
    }











}