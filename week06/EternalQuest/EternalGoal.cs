class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points){}
    public override void RecordEvent()
    {
      Console.WriteLine($"Recorded progress on '{Name}'. You earned {Points} points.");  
    }
    public override string GetDetailsString()
    {
        return "[ꝏ]" + Name;
    }
}