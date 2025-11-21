public class Goal
{
    // Attributes
    protected int _points;
    protected string _goalName;
    protected string _description;
    protected bool _isCompleted;
    protected string _goalType;

    // Behaviors    
    public void SetCompleted(bool value)
    {
        _isCompleted = value;
    }
    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _description = description;
        _points = points;
        _isCompleted = false;
    }
    public virtual int RecordEvent()
    {
        if (_isCompleted == false)
        {
            _isCompleted = true;
            return _points;
        }
        else
        {
            return 0;
        }
    }
    public virtual string DisplayStatus()
    {
        if (_isCompleted == false)
        {
            return $"[ ] {_goalName} ({_description})";
        }
        else
        {
            return $"[x] {_goalName} ({_description})";
        }
    }
    public virtual string ToData()
    {
        return $"{_goalType}|{_goalName}|{_description}|{_points}|{_isCompleted}";
    }
}