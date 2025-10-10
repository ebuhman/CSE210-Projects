class Entry
{
    // Store entry info
    public string _entryDateTime;
    public string _currentPrompt;
    public string _entryText;

    // Display one entry
    public void Display()
    {
        Console.WriteLine($"{_entryDateTime} -- {_currentPrompt}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }

    // Method for saving to file later
    public string ToFileFormat()
    {
        return $"{_entryDateTime}|{_currentPrompt}|{_entryText}";
    }
}
