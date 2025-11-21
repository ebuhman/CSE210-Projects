public class Simple : Goal
{
    public Simple(string name, string description, int points) : base(name, description, points)
    {
        _isCompleted = false;
    }
    public override string ToData()
    {
        return $"Simple|{_goalName}|{_description}|{_points}|{_isCompleted}";
    }
}