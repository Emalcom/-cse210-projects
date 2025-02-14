class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, int points) : base(name, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");
        }
        else{
            Console.WriteLine("This goal is already completed.");
        }
    }
    public override string GetDetailsString()
    {
        return _isComplete ? "[X]" + Name : "[ ]" + Name;
    }
    public override string GetSaveString()
    {
        return base.GetSaveString() + $",{_isComplete}";
    }

}