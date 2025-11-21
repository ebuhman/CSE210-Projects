public class Menu : Manager
{
    public void DisplayMenu()
    {
        Console.WriteLine($"You have {_totalPoints} points\n");
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");
        Console.Write("Select an option from the menu: ");
    }
    public void RunProgram()
    {
        bool running = true;

        while (running)
        {
            DisplayMenu();
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                SetGoal();
            }
            if (input == "2")
            {
                ListGoals();
            }
            if (input == "3")
            {
                SaveGoals();
            }
            if (input == "4")
            {
                LoadGoals();
            }
            if (input == "5")
            {
                RecordGoalEvent();
            }
            if (input == "6")
            {
                break;
            }
        }
    }
}