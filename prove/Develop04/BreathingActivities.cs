public class Breathing : Activities
{
    // Attributes
    private int _breathing1;
    private int _breathing2;

    // Behaviors
    public Breathing() : base("Welcome to the Reflection Activity.\n\n", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n\n")
    {
        _breathing1 = 6;
        _breathing2 = 4;
    }
    public void DisplayBreath()
    {
        Console.Write($"Get ready...");
        DisplayAnimation(3);
        Console.WriteLine();
        while (_endCount > 0)
        {
            Console.Write("Breathe in...");
            SingularCountdown(4);
            Console.WriteLine();

            Console.Write("Breathe out...");
            SingularCountdown(6);
            Console.WriteLine("\n");

            _endCount -= (_breathing1 + _breathing2);
        }
        DisplayEndMessage("Breathing Activity");
    }
}