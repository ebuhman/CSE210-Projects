public class WeaponEvent : Event
{
    public WeaponEvent()
    {
        _difficulty = _random.Next(1, 3);      // 1 = normal sword, 2 = strong weapon
    }

    public override void Execute(Player player)
    {
        Console.WriteLine("As you continue on the path, you spot an object lodged in a passing tree.");
        Console.WriteLine("Would you like to investigate it? yes/no ");

        string input = Console.ReadLine()?.ToLower();

        if (input == "yes")
        {
            Console.WriteLine("You decide to investigate the object.");
            Console.WriteLine("As you approach, you find that it is a pearl white sword!");
            Console.WriteLine("You pull the sword out, admiring its craftsmanship.");

            int bonus = 2 * _difficulty; // difficulty-based weapon bonus

            Console.WriteLine($"The sword feels balanced and powerful.");
            Console.WriteLine($"You gain a permanent +{bonus} to your attack power!");

            player.IncreaseAttack(bonus);
        }
        else
        {
            Console.WriteLine("You decide it's not worth the risk and continue your journey.");
        }
    }
}
public class TrapEvent : Event
{
    public TrapEvent()
    {
        _difficulty = _random.Next(1, 3);  // 1 = small trap, 2 = strong trap
    }

    public override void Execute(Player player)
    {
        Console.WriteLine("As you travel along the path, something catches your eye in a nearby tree.");
        Console.WriteLine("Would you like to investigate it? yes/no ");

        string input = Console.ReadLine()?.ToLower();

        if (input == "yes")
        {
            Console.WriteLine("You cautiously approach the object...");
            Console.WriteLine("Suddenly, a hidden creature lashes out and strikes you!");

            int damage = 8 * _difficulty;

            int actualDamage = player.TakeDamage(damage);

            Console.WriteLine($"The trap deals {actualDamage} damage!");
            Console.WriteLine($"You now have {player.GetHealth()} HP remaining.");
        }
        else
        {
            Console.WriteLine("You ignore the suspicious object and move along the path.");
        }
    }
}

public class PotionEvent : Event
{
    public override void Execute(Player player)
    {
        Console.WriteLine("As you continue on your journey, you see a travelling wizard!");
        Console.WriteLine("You walk towards them, raising your hand in greeting!");
        Console.WriteLine("Hello there sir wizard! How are your travels!");
        Console.WriteLine("The wizard regards you, a warm smile stretching across his face.");
        Console.WriteLine("He invites you to rest with him for lunch, and begins the tale of his journeys thus far.");
        Console.WriteLine("You listen intently for a while, before the wizard breaks and begins to stand");
        Console.WriteLine("Before he leaves, he offers you one of two potions, one blue, and one green.");
        Console.WriteLine("Which do you take? blue/green ");
        
        bool answer = true;
        string input = Console.ReadLine()?.ToLower();

        while (answer)
        {
            if (input == "green")
            {
                Console.WriteLine("You decide to take the green potion.");
                Console.WriteLine("You drink it, and instantly feel a surge of invigoration!");

                int healing = 5 * _difficulty;
                player.HealPlayer(healing);
                

                Console.WriteLine($"You were healed! You now have {player.GetHealth()} HP!");
                Console.WriteLine("You go along your merry way, happy with the encounter.");
                answer = false;
            }
            else if (input == "blue")
            {
                Console.WriteLine("You decide to take the blue potion.");
                Console.WriteLine("You drink it, and instantly feel a tightness in your muscles!");

                int defense = 1 * _difficulty;
                player.IncreaseDefense(defense);

                Console.WriteLine($"Your defense raised by {defense} point(s)! You now have {player.GetDefense()} defense!");
                Console.WriteLine("You go along your merry way, happy with the encounter.");
                answer = false;
            }
            else
            {
                Console.WriteLine("Sorry, that's not a valid input!");
            }
            
        }
    }
}
public class WorkEvent : Event
{
    public override void Execute(Player player)
    {
        Console.WriteLine("As you continue on your journey, you notice some lumberman on the side of the road.");
        Console.WriteLine("As you go up to them, you realize they are missing a saw.");
        Console.WriteLine("Ingenuity sparks, as you pull out your battle sword, chopping each piece of wood for them.");
        Console.WriteLine("The lumberman are extremely grateful for your efforts, lest they have been stuck there for even longer.");
        
        int experienceGained = 4 * _difficulty;
        Console.WriteLine($"You received {experienceGained} for working so hard!");
        player.AddExperience(experienceGained);    
    }
}


