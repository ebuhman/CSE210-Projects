public class Eternal : Goal
{
    // Methods
    public Eternal(string name, string description, int points) : base(name, description, points)
    {
        
    }
    public override int RecordEvent()
    {
        return _points;
    }
    public override string ToData()
    {
        return $"Eternal|{_goalName}|{_description}|{_points}|{_isCompleted}";
    }
}