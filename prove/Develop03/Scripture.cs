class Scripture
{
    // Attributes
    private List<string> _references;
    private List<List<string>> _verses;  // each verse stored as list of words
    private Random random = new Random();
    private int _currentIndex = -1;
    private List<Word> _currentWords;

    
    // Behaviors

    private void AddScripture(string reference, string verseText)
    {
        _references.Add(reference);
        _verses.Add(new List<string>(verseText.Split(' ')));
    }
    public Scripture()
    {
        _references = new List<string>();
        _verses = new List<List<string>>();

        // Load verses (constructor only stores data — no Console output!)
        AddScripture(new Reference("Proverbs", 3, 5, 6).GetFullReference(),
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");

        AddScripture(new Reference("Philippians", 4, 13, null).GetFullReference(),
            "I can do all things through Christ which strengtheneth me.");

        AddScripture(new Reference("John", 3, 16, null).GetFullReference(),
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        AddScripture(new Reference("Psalm", 23, 1, null).GetFullReference(),
            "The Lord is my shepherd; I shall not want.");

        AddScripture(new Reference("Joshua", 1, 9, null).GetFullReference(),
            "Be strong and of a good courage; be not afraid, neither be thou dismayed: for the Lord thy God is with thee whithersoever thou goest.");

        AddScripture(new Reference("Psalm", 91, 1, 2).GetFullReference(),
            "He that dwelleth in the secret place of the most High shall abide under the shadow of the Almighty; I will say of the Lord, He is my refuge and my fortress: my God; in him will I trust.");

        AddScripture(new Reference("Matthew", 5, 14, 16).GetFullReference(),
            "Ye are the light of the world; A city that is set on an hill cannot be hid; Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house; Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven.");

        AddScripture(new Reference("Philippians", 4, 6, 7).GetFullReference(),
            "Be careful for nothing; but in every thing by prayer and supplication with thanksgiving let your requests be made known unto God; And the peace of God, which passeth all understanding, shall keep your hearts and minds through Christ Jesus.");

        AddScripture(new Reference("Romans", 12, 1, 2).GetFullReference(),
            "I beseech you therefore, brethren, by the mercies of God, that ye present your bodies a living sacrifice, holy, acceptable unto God, which is your reasonable service; And be not conformed to this world; but be ye transformed by the renewing of your mind, that ye may prove what is that good, and acceptable, and perfect, will of God.");
    }

    public void ShowRandomScripture()
    {
        _currentIndex = random.Next(_references.Count);
        _currentWords = new List<Word>();

        foreach (string word in _verses[_currentIndex])
        {
            _currentWords.Add(new Word(word));
        }

        Display();
    }

    public bool HideMoreWords(int countToHide = 3)
    {
        if (_currentIndex == -1 || _currentWords == null)
            return false;

        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _currentWords)
        {
            if (!word.IsHidden())
                visibleWords.Add(word);
        }

        if (visibleWords.Count == 0)
            return false;

        for (int i = 0; i < countToHide && visibleWords.Count > 0; i++)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }

        Display();

        // Return false if all words are now hidden
        foreach (Word word in _currentWords)
        {
            if (!word.IsHidden())
                return true;
        }

        return false;
    }

    private void Display()
    {
        Console.Clear();
        Console.WriteLine(_references[_currentIndex]);

        string displayText = "";
        foreach (Word word in _currentWords)
        {
            displayText += word.GetDisplayText() + " ";
        }

        Console.WriteLine(displayText.TrimEnd());
    }
}

