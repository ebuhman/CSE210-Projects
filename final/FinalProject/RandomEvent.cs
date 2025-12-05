public class RandomEventGenerator
{
    // Attributes 
    private int _eventsSinceBoss = 0;
    Random _random = new Random();
    List<Event> _events = new List<Event>()
    {
        new WorkEvent(),
        new WeaponEvent(),
        new PotionEvent(),
        new TrapEvent(),
    };

    // Behaviors
    public void GenerateEvent(Player player)
    {
        // If 6 events have happened, force a boss event
        if (_eventsSinceBoss >= 6)
        {
            _eventsSinceBoss = 0; 
            new BossEvent().Execute(player);
        }
        int roll = _random.Next(1, 101); // 1 to 100

        if (roll <= 70)
        {
            _eventsSinceBoss++;
            new Combat().Execute(player);
        }
        else
        {
            _eventsSinceBoss++;
            Event randomEvent = _events[_random.Next(_events.Count())];
            randomEvent.Execute(player);
        }
    }

}