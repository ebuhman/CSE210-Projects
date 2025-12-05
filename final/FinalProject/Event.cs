public class Event
{
    // Attributes
    protected Random _random = new Random();
    protected int _difficulty;

    // Behaviors
    public Event()
    {
        _difficulty = _random.Next(1, 3); // difficulty 1–2
    }
    public virtual void Execute(Player player)
    {
        
    }
}