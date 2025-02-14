class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    public void CreateGoal()
    {
        Console.WriteLine("Choose goal type: 1) Simple 2) Eternal 3) Checklist");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
            _goals.Add(new SimpleGoal(name, points));
            break;
            case 2:
            _goals.Add(new EternalGoal(name, points));
            break;
            case 3:
            Console.Write("Enter target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, points, target, bonus));
            break;
        }
    }
    public void RecordGoalEvent()
    {
        Console.WriteLine("Select a goal to record progress:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        int index = int.Parse(Console.ReadLine()) -1;
        _goals[index].RecordEvent();
    }
    public void ShowGoals()
    {
        Console.WriteLine("Your goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
}