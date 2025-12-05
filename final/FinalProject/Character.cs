public class Character
{
    // Attributes
    protected static Random _random = new Random();
    protected int _damage;
    protected int _critChance;
    protected int _maxHealth;
    protected int _health;
    protected int _attackPower;
    protected int _defense;
    protected string _name;

    // Behaviors
    public Character(int maxHealth, int defense, int attackPower)
    {
        _maxHealth = maxHealth;
        _health = maxHealth;
        _defense = defense;
        _attackPower = attackPower;
        _critChance = 6;
    }
    public int GetDefense()
    {
        return _defense;
    }
    public int GetHealth()
    {
        return _health;
    }

    public int GetMaxHealth()
    {
        return _maxHealth;
    }
    public virtual int Attack()
    {
        _damage = _attackPower;
        int _damageRoll = _random.Next(0, 100); // Sets a random generator for crit chance

        if (_damageRoll < _critChance)
        {
            _damage = Convert.ToInt32(_damage * 1.5);
        }

        return _damage;
    }
   public virtual int TakeDamage(int incomingAttack)
    {
        if (incomingAttack <= _defense)
        {
            _damage = 0;
        }
        else
        {
            _damage = incomingAttack - _defense;
        }
        
        _health -= _damage;
        if (_health < 0)
            _health = 0;

        return _damage;
    }
    public virtual bool IsAlive()
    {
        return _health > 0;
    }
    public void Display()
    {
        Console.WriteLine($"The Character's max health is {_maxHealth}, their current health is {_health}, their defense modifier is {_defense}, and their attack power is {_attackPower}");
    }
}