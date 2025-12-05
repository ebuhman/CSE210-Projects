public class Boss : Character
{
    // Attributes
    private string _specialAttackName;

    // Behaviors
    public Boss() : base(50, 3, 6)
    {
        _critChance = 8;
        _specialAttackName = "Heavy Bludgeon";
    }
    public void PrepareAttack()
    {
        Console.WriteLine("The air trembles as the boss lifts its massive club. A devastating blow is coming…");
    }
    public int UseSkill()
    {
        int _damage = Convert.ToInt32(_attackPower * 1.5);
        int _damageRoll = _random.Next(0, 100); // Sets a random generator for crit chance

        if (_damageRoll < _critChance)
        {
            _damage = Convert.ToInt32(_damage * 1.5);
        }

        return _damage;
    }
}