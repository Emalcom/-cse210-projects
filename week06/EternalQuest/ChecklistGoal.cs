class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;

    }
    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            int earnedPoints = _currentCount == _targetCount ? Points + _bonusPoints : Points;
            Console.WriteLine($"Completed '{Name}' {_currentCount}/{_targetCount} times.Earned {earnedPoints} points.");
        }
        else{
            Console.WriteLine($"'{Name}' has already been fully completed.");
        }
    }
    public override string GetDetailsString()
    {
        return _currentCount >= _targetCount ? "[X]" + Name + $"(Completed {_currentCount}/{_targetCount})" : "[ ]" + Name + $"(Complete {_currentCount}/{_targetCount})";
    }
}