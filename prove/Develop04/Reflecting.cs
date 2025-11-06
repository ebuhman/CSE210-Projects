public class Reflecting : Activities
{
    // Attributes
    private int _currentIndex;
    private List<string> _prompts = new List<string>()
    {
        "--- Think of a time when you overcame a challenge. ---",
        "--- Recall a moment when you helped someone else. ---",
        "--- Think of a time when you felt truly proud of yourself. ---",
        "--- Reflect on a situation where you stayed calm under pressure. ---",
        "--- Consider a time when you learned something important about yourself. ---",
    };
    private List<string> _promptQuestions = new List<string>()
    {
        "> What emotions did you experience during this situation? ",
        "> Why do you think this moment was meaningful to you? ",
        "> What did you learn about yourself through this experience? ",
        "> How did your actions affect others involved? ",
        "> What thoughts were going through your mind at the time? ",
        "> If you could revisit this moment, would you do anything differently? ",
        "> What strengths or qualities did you use in this situation? ",
        "> How has this experience shaped who you are today? ",
        "> What challenges did you face, and how did you overcome them? ",
        "> How can you apply what you learned from this moment in your life now? "
    };
    private Random _rand = new Random();
    public Reflecting() : base("Welcome to the Reflecting Activity\n\n", "this activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n\n")
    {
        
    }

    // Behaviors
    public void GetRandomPrompt()
    {
        _currentIndex = _rand.Next(_prompts.Count);
        Console.WriteLine(_prompts[_currentIndex]);
    }
    public void GetRandomQuesion()
    {
        _currentIndex = _rand.Next(_promptQuestions.Count);
        Console.Write(_promptQuestions[_currentIndex]);
    }
    public void DisplayReflection()
    {
        Console.Clear();
        Console.Write("Get ready...");
        DisplayAnimation(3);
        Console.WriteLine("\n");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue ");
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience");
            Console.WriteLine("You may begin in: ");
            SingularCountdown(5);
            Console.Clear();
            while (_endCount > 0)
            {
                GetRandomQuesion();
                Console.WriteLine();
                
                Thread.Sleep(10000);
                _endCount -= 10;
            }
            DisplayEndMessage("Reflecting Activity");
        }
        else
        {
            Console.WriteLine("That input was invalid");
        }

    }
}
