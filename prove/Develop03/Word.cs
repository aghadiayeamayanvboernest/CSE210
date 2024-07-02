using System.Reflection.Metadata.Ecma335;

public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
    public void Hide()
    {
        _hidden = true;  
    }

    public void Show()
    {
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetDisplayText()
    {
        if (_hidden)
        {
            return new string('_', _word.Length);
        }
        else
        {
            return _word;
        }
    }
}
