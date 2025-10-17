class Word
{
    // Attributes
    private string _wordUsed;
    private int _length;
    private bool _isHidden;


    // Behaviors
    public Word(string word)
    {
        _wordUsed = word;
        _length = word.Length;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _length);
        }
        else
        {
            return _wordUsed;
        }
    }
    
}
