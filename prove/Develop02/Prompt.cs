class Prompt
{
    // attributes
    public string _currentPrompt;
    public string _entryDateTime;
    public string _entryText;
    public Random _randomInteger = new Random();
    public List<string> _promptList = new List<string>
    {
        "What was your favorite conference talk? ", "What was something beautiful you saw today? ", "If you could have one superpower, what would it be and why? ", "Did anything happen today that bothered you? "
    };

    // behaviors
    public string randomPrompt()
    {
        int index = _randomInteger.Next(_promptList.Count);
        return _promptList[index];
    }
    public void Display()
    {
        Console.Write($"{_entryDateTime} -- ");
        Console.WriteLine($"{_currentPrompt}");
        Console.WriteLine($"{_entryText}");
    }
    
}