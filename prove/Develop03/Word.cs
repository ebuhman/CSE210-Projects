class Word
{
    // Attributes
    private string _wordUsed;
    private bool _isHidden;

    // Behaviors
    public Word(string word) // Constructor
    {
        _wordUsed = word;
        _isHidden = false;
    }

    // Hides Word
    public void Hide()
    {
        _isHidden = true;
    }

    // Reveals Word
    public void Show()
    {
        _isHidden = false;
    }

    // Checks if Hidden
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText() // getter
    {
        if (_isHidden == true)
        {
            // Replace each character in the word with an underscore
            string hiddenWord = "";
            for (int i = 0; i < _wordUsed.Length; i++)
            {
                hiddenWord += "_";
            }
            return hiddenWord;
        }
        else
        {
            return _wordUsed;
        }
    }
}
