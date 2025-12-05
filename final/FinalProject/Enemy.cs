public class Enemy : Character
{
    // Attributes
    private EnemyType _type;
    protected int _agressionLvl;
    private int _experienceValue;

    // Behaviors
     public enum EnemyType
    {
        Goblin,
        Slime,
        Skeleton
    }
    public int GetExperienceReward()
    {
        return _experienceValue;
    }
    public override int Attack()
    {
        int baseDamage = base.Attack();  // calculates attack + crit
        int _attackVariance = _random.Next(-2, 3);
        int finalDamage = baseDamage + _agressionLvl + _attackVariance;
        return finalDamage;
    }
    public Enemy(EnemyType _type) : base(0,0,0)
    {
        switch (_type)
        {
            case EnemyType.Goblin:
                _maxHealth = 20;
                _defense = 2;
                _attackPower = 5;
                _experienceValue = 10;
                break;

            case EnemyType.Slime:
                _maxHealth = 35;
                _defense = 1;
                _attackPower = 3;
                _experienceValue = 5;
                break;

            case EnemyType.Skeleton:
                _maxHealth = 25;
                _defense = 4;
                _attackPower = 4;
                _experienceValue = 15;
                break;
        }

        
        _health = _maxHealth;
    }
}   