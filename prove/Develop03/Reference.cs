public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _endVerse;

    public Reference(string book, int chapter, int verseStart)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;

    }
    public Reference(string book, int chapter, int verseStart, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _endVerse = endVerse;       
    }

    public string GetDisplayText()
    {
       if (_endVerse == _verseStart)
       {
        return $"{_book} {_chapter}:{_verseStart}-{_endVerse}";
       }
       else
       {
        return $"{_book} {_chapter}:{_verseStart}";
       }
    }
}