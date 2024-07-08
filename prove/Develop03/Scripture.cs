public class Scripture
{
    private List<Word> _scriptureWords;
    private Reference _scriptureReference;

    public Scripture(string text, Reference reference)
    {
        _scriptureReference = reference;
        _scriptureWords = text.Split(' ').Select(word => new Word(word)).ToList();
    } 

    public string GetDisplayText()
    {
        string scriptureText = string.Join(' ', _scriptureWords.Select(word => word.GetDisplayText()));
        return $"{_scriptureReference.GetDisplayText()}\n{scriptureText}";
    }

    public void HideRandomWords(int numberToHide)
    {
        var visibleWords = _scriptureWords.Where(word => !word.IsHidden()).ToList();
        var random = new Random();
        for (int i = 0; i < numberToHide && visibleWords.Any(); i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
    public bool IsCompletelyHidden()
    {
        return _scriptureWords.All(Word => Word.IsHidden());
    }
}