class Reference
{
    // Attributes
    private string _bookName;
    private int _chapter;
    private int _verse;
    private int? _endVerse;

    // Behaviors
    public Reference()
    {
        _bookName = " ";
        _chapter = 0;
        _verse = 0;
        _endVerse = null;
    }
    public Reference(string book, int chapter, int verse, int? endVerse)
    {
        _bookName = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetVerses()
    {
        if (_endVerse is not null)
        {
            string text = $"{_verse}-{_endVerse}";
            return text;
        }
        else
        {
            string text = $"{_verse}";
            return text;
        }
    }
    public string GetFullReference()
    {
        string text = $"{_bookName} {_chapter}:{GetVerses()}";
        return text;
    }
}