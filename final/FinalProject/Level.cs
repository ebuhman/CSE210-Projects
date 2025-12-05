public class Level
{
    // Attributes
    private string _levelName;
    private RandomEventGenerator _eventGenerator;
    private Player _player;

    // Constructor
    public Level(string levelName, Player player)
    {
        _levelName = levelName;
        _player = player;
        _eventGenerator = new RandomEventGenerator();
    }

    // Behaviors
    public void StartLevel()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_levelName}!");
        Console.WriteLine("Your adventure begins...\n");

        bool gameRunning = true;

        while (gameRunning)
        {
            Console.Clear();
            
            Console.WriteLine("\n--- Player Stats ---");
            _player.PlayerDisplay(); // Displays Stats
            Console.WriteLine("-------------------\n");
            _eventGenerator.GenerateEvent(_player);

            // Check for end conditions (Player death)
            if (!_player.IsAlive())
            {
                Console.WriteLine("\nYou have been defeated. Game Over.");
                gameRunning = false;
                break;
            }
            // Optional: let player choose to quit
            Console.WriteLine("\nPress Q to quit or Enter to continue your adventure...");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && input.ToLower() == "q")
            {
                Console.WriteLine("You have ended your adventure. Goodbye!");
                gameRunning = false;
                break;
            }
        }
    }
}