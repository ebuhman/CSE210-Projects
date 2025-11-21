public class Checklist : Goal
{
    // Attributes
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    // Methods
    public Checklist(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _targetCount = target;
        _bonusPoints = bonus;
        _currentCount = 0;
        _isCompleted = false;
    }
    public void SetCurrentCount(int count)
    {
        _currentCount = count;
    }
    public override int RecordEvent()
    {
        _currentCount++;

        if (_currentCount == _targetCount)
        {
            _isCompleted = true;
            return _points + _bonusPoints;
        }

        return _points;
    }
    public override string DisplayStatus()
    {
        if (_currentCount != _targetCount)
        {
            return $"[ ] {_goalName} ({_description}) -- {_currentCount}/{_targetCount}";
        }
        else
        {
            return $"[x] {_goalName} ({_description}) -- Currently completed: {_currentCount}/{_targetCount}";
        }
    }
    public override string ToData()
    {
        return $"{_goalType}|{_goalName}|{_description}|{_points}|{_isCompleted}|{_currentCount}|{_targetCount}|{_bonusPoints}";
    }
}