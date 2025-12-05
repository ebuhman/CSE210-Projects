public class Combat : Event
{
    // Attributes
    public Enemy _enemy;
    private Enemy.EnemyType _randomType;

    // Behaviors
    public Combat() // sets the random enemy type for the event
    {
        _randomType = GetEnemy();
        _enemy = new Enemy(_randomType);
    }
    private Enemy.EnemyType GetEnemy() // Creates a list of the enumerated enemy types, and then randomizes the index
    {
        Enemy.EnemyType[] types = (Enemy.EnemyType[])Enum.GetValues(typeof(Enemy.EnemyType));
        int index = _random.Next(types.Length);
        return types[index];
    }
    public override void Execute(Player player)
    {

        Console.WriteLine($"An {_randomType} appears!");
        Console.WriteLine();

        while (player.IsAlive() && _enemy.IsAlive())
        {
            Console.WriteLine("Choose an action");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");
            Console.WriteLine("3. Run Away");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                int damage = player.Attack();
                int actualDamage = _enemy.TakeDamage(damage);
                Console.WriteLine($"You did {actualDamage} dmg to the {_randomType}!");
                Console.WriteLine($"Enemy health: {_enemy.GetHealth()} / {_enemy.GetMaxHealth()}");
                Console.WriteLine();
            }
            if (choice == "2")
            {
                player.Defend();
            }
            if (choice == "3")
            {
                if (player.RunAway())
                {
                    Console.WriteLine("You successfully escaped!");
                    break;
                }
                else
                {
                    Console.WriteLine("You failed to run away!");
                }
            }
            if (_enemy.IsAlive()) // After player's turn, the enemy will attack
            {
                Console.WriteLine($"The {_randomType} attacks!");
                int enemyDamage = _enemy.Attack();
                int enemyActualDamage = player.TakeDamage(enemyDamage);
                Console.WriteLine($"You took {enemyActualDamage} dmg!");
                Console.WriteLine($"Enemy health: {player.GetHealth()} / {player.GetMaxHealth()}");
                Console.WriteLine();
            }
        }
        if (!_enemy.IsAlive()) // Checks if enemy is defeated before applying experience and breaking the loop
        {
            Console.WriteLine($"You defeated the {_randomType}");
            int reward = _enemy.GetExperienceReward();
            player.AddExperience(reward); 
        }
    }

    
}