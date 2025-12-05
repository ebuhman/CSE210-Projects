public class Player : Character
{
    // Attributes
    private int _experience;
    private int _level;
    private int _expToLevel;
    private int _defenseBoost = 2;
    private bool _isDefending = false;

    // Behaviors
    public Player() : base(50, 4, 8)
    {
        _level = 1;
        _experience = 0;
        _expToLevel = 50;
    }
    public void HealPlayer(int amount)
    {
        _health += amount;
        if (_health > _maxHealth)
        {
            _health = _maxHealth;
        }
    }
    public void IncreaseMaxHealth(int amount)
    {
        _maxHealth += amount;
        _health += amount;
    }
    public void IncreaseAttack(int amount)
    {
        _attackPower += amount;
    }
    public void IncreaseDefense(int amount)
    {
        _defense += amount;
    }
    public bool RunAway()
    {
        int _runAway = _random.Next(0, 100);
        return _runAway < 50;
    }
    public void Defend()
    {
        _isDefending = true;
        Console.WriteLine("You bring your guard up! You have +2 defense for the rest of the turn!");
    }
    public override int TakeDamage(int incomingAttack)
    {
        int _originalDefense = _defense;
        if (_isDefending)
        {
            _defense += _defenseBoost;
        }

        int _damageTaken = base.TakeDamage(incomingAttack);

        _defense = _originalDefense;
        _isDefending = false;

        return _damageTaken;
    }
    public void AddExperience(int amount)
    {
        _experience += amount;
        Console.WriteLine($"You gained {amount} amount of experience! ({_experience}/{_expToLevel})");

        LevelUp(); // Does nothing if the loop cannot start
    }
    public void LevelUp()
    {
        while (_experience >= _expToLevel)
        {
            _experience -= _expToLevel;
            _level ++;

            _maxHealth += 5;
            _health = _maxHealth;
            _defense += 2;
            _attackPower += 1;

            _expToLevel = Convert.ToInt32(_expToLevel * 1.2);
            Console.WriteLine($"You leveled up to level {_level}! Your stats have increased!");
        }
    }
    public void PlayerDisplay()
    {
        Console.WriteLine($"Level:      {_level}");
        Console.WriteLine($"Health:     {_health}/{_maxHealth}");
        Console.WriteLine($"Attack:     {_damage}");
        Console.WriteLine($"Defense:    {_defense}");
        Console.WriteLine($"EXP:        {_experience}/{_expToLevel}");
    }
}
