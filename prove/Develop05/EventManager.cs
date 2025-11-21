using System.IO;
using System.Runtime.InteropServices;

public class Manager
{
    // Attributes
    private string _stringPoints;
    protected int _totalPoints;
    private List<Goal>_goals = new List<Goal>();
    private bool validInput = true;
    private string _fileName;

    public void SetGoal()
    {
        validInput = true;

        Console.WriteLine("The types of Goals are:\n    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal");

        Console.Write("What type of goal would you like to create? ");
        string input = Console.ReadLine();
        int number = int.Parse(input);

        while (validInput == true)
        {
            if (number == 1)
            {
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                
                Console.Write("What is a short description for your goal? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                Simple newGoal = new Simple(name, description, points);

                _goals.Add(newGoal);

                validInput = false;
            }
            else if (number == 2)
            {
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                
                Console.Write("What is a short description for your goal? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                Eternal newGoal = new Eternal(name, description, points);

                _goals.Add(newGoal);

                validInput = false;

            }
            else if (number == 3)
            {
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                
                Console.Write("What is a short description for your goal? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                Console.Write("How many times does this goal need to be accomplished for this bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                Checklist newGoal = new Checklist(name, description, points, target, bonus);

                _goals.Add(newGoal);
                
                validInput = false;
            }
            else
            {
                Console.Write("Invalid choice. Please enter 1, 2, or 3: ");
                input = Console.ReadLine();
                number = int.Parse(input);
            }
        }
    }
    public void SaveGoals()
    {
        Console.Write("What is the file name for the goal file? ");
        _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine($"{_totalPoints}");
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.ToData());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        _fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        _totalPoints = int.Parse(lines[0]);
        _goals = new List<Goal>();

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split("|");
            
            string goalType = parts[0];

            if (goalType == "Simple")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                Simple newGoal = new Simple(name, description, points);
                newGoal.SetCompleted(bool.Parse(parts[4]));
                _goals.Add(newGoal);
            }
            if (goalType == "Eternal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                Eternal newGoal = new Eternal(name, description, points);
                _goals.Add(newGoal);
            }
            if (goalType == "Checklist")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int target = int.Parse(parts[6]);
                int bonus = int.Parse(parts[7]);
                Checklist newGoal = new Checklist(name, description, points, target, bonus);
                newGoal.SetCurrentCount(int.Parse(parts[5]));
                newGoal.SetCompleted(bool.Parse(parts[4]));
                _goals.Add(newGoal);
            }
        }
    }
    public void ListGoals()
    {
        Console.WriteLine("\nYour goals:");
        for (int i = 0; i < _goals.Count; i++)
            {
                Console.Write($"{i + 1}. "); 
                Console.WriteLine(_goals[i].DisplayStatus()); 
            }
        Console.WriteLine();
    }
    public void RecordGoalEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoals();
        Console.Write("Which goal did you complete? ");
        int index = int.Parse(Console.ReadLine());

        int earned = _goals[index - 1].RecordEvent();

        _totalPoints += earned;

        Console.WriteLine($"Congratulations! You have earned {earned} points");
        Console.WriteLine($"You now have {_totalPoints}");
    }
}