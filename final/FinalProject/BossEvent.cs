public class BossEvent : Event
{
    public override void Execute(Player player)
    {
        Console.Clear();
        Boss boss = new Boss();

        Console.WriteLine($"A Boss appears!");
        Console.WriteLine();

        bool isCharging = false;  // Tracks if boss is charging a special attack

        while (player.IsAlive() && boss.IsAlive())
        {
            Console.WriteLine("Choose an action");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Defend");
            Console.WriteLine("3. Run Away");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                int damage = player.Attack();
                int actualDamage = boss.TakeDamage(damage);
                Console.WriteLine($"You dealt {actualDamage} damage!");
                Console.WriteLine($"Boss HP: {boss.GetHealth()} / {boss.GetMaxHealth()}");
                Console.WriteLine();
            }
            else if (choice == "2")
            {
                player.Defend();
                Console.WriteLine("You brace for impact!");
                Console.WriteLine();
            }
            else if (choice == "3")
            {
                Console.WriteLine("You cannot run from a boss!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid choice!");
                Console.WriteLine();
                continue;
            }
            // Stop enemy turn if boss dies
            if (!boss.IsAlive())
                break;

            if (!isCharging && boss.GetHealth() <= boss.GetMaxHealth() / 2)
            {
                // Boss enters charging state
                boss.PrepareAttack();
                isCharging = true;
            }
            else if (isCharging)
            {
                // Boss releases its special attack
                Console.WriteLine($"The boss unleashes its special attack: Heavy Bludgeon!");
                int specialDamage = boss.UseSkill();
                int realDamage = player.TakeDamage(specialDamage);

                Console.WriteLine($"The boss dealt {realDamage} special damage!");
                Console.WriteLine($"Your HP: {player.GetHealth()} / {player.GetMaxHealth()}");
                Console.WriteLine();

                isCharging = false; // Reset after special attack
            }
            else
            {
                // Normal attack
                Console.WriteLine($"The boss swings at you!");
                int enemyDamage = boss.Attack();
                int actual = player.TakeDamage(enemyDamage);

                Console.WriteLine($"You took {actual} damage!");
                Console.WriteLine($"Your HP: {player.GetHealth()} / {player.GetMaxHealth()}");
                Console.WriteLine();
            }
        }
        if (!boss.IsAlive())
        {
            Console.WriteLine("You defeated the Boss!");
            player.AddExperience(100);

            Console.WriteLine("\nThank you for playing my game! I hope it was enjoyable, despite how simple it is!");
            Environment.Exit(0);
        }
    }
}
