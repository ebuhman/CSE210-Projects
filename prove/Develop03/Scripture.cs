class Scripture
{
    // Attributes
    private List<Reference> _references;
    private List<List<Word>> _verses;
    private Random _random;
    private int _currentIndex;
    private List<Word> _currentWords;
    private void LoadScriptureData()
    {
        // Add references
        _references.Add(new Reference("Proverbs", 3, 5, 6));
        _references.Add(new Reference("Philippians", 4, 13, null));
        _references.Add(new Reference("John", 3, 16, null));

        // Add matching verses
        List<string> verseTexts = new List<string>();
        verseTexts.Add("Trust in the Lord with all thine heart; and lean not unto thine own understanding.");
        verseTexts.Add("I can do all things through Christ which strengtheneth me.");
        verseTexts.Add("For God so loved the world, that he gave his only begotten Son.");

        // Split each verse into words
        for (int i = 0; i < verseTexts.Count; i++)
        {
            string verse = verseTexts[i];
            string[] parts = verse.Split(' ');
            List<Word> wordList = new List<Word>();

            foreach (string part in parts)
            {
                Word word = new Word(part);
                wordList.Add(word);
            }

            _verses.Add(wordList);
        }
    }
    // Behaviors
    public Scripture() // Constructor
    {
        _references = new List<Reference>();
        _verses = new List<List<Word>>();
        _random = new Random();

        // Load all scriptures and verses
        LoadScriptureData();
    }
    public void ShowRandomScripture()
    {
        _currentIndex = _random.Next(_references.Count);
        _currentWords = _verses[_currentIndex];
        Display();
    }
    public bool HideMoreWords()
    {
        int wordsHidden = 0;

        // Go through each word
        foreach (Word word in _currentWords)
        {
            // If the word is not hidden, decide randomly to hide it
            if (word.IsHidden() == false)
            {
                if (_random.Next(2) == 0) // 50% chance
                {
                    word.Hide();
                    wordsHidden++;
                }

                // Stop after hiding 3 words
                if (wordsHidden >= 3)
                {
                    break;
                }
            }
        }

        // Show the verse again after hiding some words
        Display();

        // Check if any words are still visible
        bool _anyVisible = false;
        foreach (Word word in _currentWords)
        {
            if (word.IsHidden() == false)
            {
                _anyVisible = true;
                break;
            }
        }

        return _anyVisible;
    }
    private void Display()
    {
        Console.Clear();

        // Show the scripture reference
        Console.Write(_references[_currentIndex].GetFullReference() + ' ');

        // Show each word (hidden or visible)
        string verseText = "";
        foreach (Word word in _currentWords)
        {
            verseText += word.GetDisplayText() + " ";
        }

        Console.WriteLine(verseText.TrimEnd());
    }
}
