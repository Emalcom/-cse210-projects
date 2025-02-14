using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager manager = new GoalManager();

        while(true)
        {
            Console.WriteLine("1) Create Goal 2) Record Event 3) Show Goals 4) Exit");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                manager.CreateGoal();
                break;
                case 2:
                manager.RecordGoalEvent();
                break;
                case 3:
                manager.ShowGoals();
                break;
                case 4:
                return;
            }
        }
    }
}