public class Listing : Activities
{
    private List<string> _userResponses = new List<string>();
    private List<string> _prompts = new List<string>()
    {
        "--- Think of a time when the Holy Ghost guided you in making a decision. ---",
        "--- Recall a moment when studying the Book of Mormon brought you comfort or clarity. ---",
        "--- Reflect on a scripture from the Book of Mormon that taught you an important lesson. ---",
        "--- Consider a situation where you felt prompted by the Holy Ghost to act. ---",
        "--- Think about a time when your study of the Book of Mormon helped you understand your purpose or strengthened your faith. ---"
    };

    private Random _rand = new Random();
    private int _currentIndex;

    public Listing() : base("Welcome to the Listing Activity.\n\n",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n\n")
    {
    }

    public void GetRandomPrompt()
    {
        _currentIndex = _rand.Next(_prompts.Count);
        Console.WriteLine(_prompts[_currentIndex]);
    }

    public void DisplayListing()
    {
        Console.Clear();
        Console.Write("Get ready...");
        DisplayAnimation(3);
        Console.WriteLine("\n");

        Console.WriteLine("List as many responses as you can to the following prompt:\n");
        GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("You may begin in: ");
        SingularCountdown(5);
        Console.Clear();

        while (_endCount > 0)
        {
            Console.Write("> "); // prompt symbol
            string input = Console.ReadLine();
            Thread.Sleep(1000);
            _endCount -= 1;

            if (!string.IsNullOrWhiteSpace(input))
            {
                _userResponses.Add(input);
            }
        }
        Console.WriteLine($"You listed {_userResponses.Count}!");
        DisplayEndMessage("Listing Activity");
    }
}
