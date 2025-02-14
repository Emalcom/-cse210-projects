abstract class Goal
{
    protected string Name;
    protected int Points;
    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
    }
    public abstract void RecordEvent();
    public abstract string GetDetailsString();
    public virtual string GetSaveString()
    {
        return $"{GetType().Name}, {Name}, {Points}";
    }

}