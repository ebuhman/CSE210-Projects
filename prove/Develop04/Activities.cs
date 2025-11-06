public class Activities
{
    // Attributes
    private bool _animation;
    private string _intro;
    private string _description;
    protected int _endCount;
    private int _originalEndCount;

    // Behaviors

    // Getters
    public void GetSecondsCount()
    {
        Console.Write("How long, in seconds, would you like your session? ");
        _endCount = int.Parse(Console.ReadLine());
        _originalEndCount = _endCount;
    }
    public int GetOriginalDuration()
    {
        return _originalEndCount;
    }
    // Setters
    public Activities(string intro, string description)
    {
        _intro = intro;
        _description = description;
    }

    public string DisplayIntro()
    {
        return _intro + _description;
    }

    public void DisplayEndMessage(string _activityType)
    {
        Console.WriteLine("Well Done!!");
        DisplayAnimation(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed {GetOriginalDuration()} seconds of the {_activityType}.");
        DisplayAnimation(5);
    }
    public void DisplayCountdown()
    {
        int countdown = _endCount;
        while (countdown > 0)
        {
            Thread.Sleep(1000);
            countdown--;
        }
    }
    public void SingularCountdown(int _countdown)
    {
        while (_countdown > 0)
        {
            Console.Write($"{_countdown}");
            Thread.Sleep(1000);

            Console.Write("\b \b");
            _countdown --;
        }
    }
    public void DisplayAnimation(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        _animation = true;

        while (_animation && DateTime.Now < endTime)
        {
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }

        _animation = false; // stop when time is up
    }

    }