using System;
using System.Collections.Generic;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3),30, 3.0),
            new Cycling(new DateTime(2022, 11, 4), 45, 12.0),
            new Swimming(new DateTime(2022, 11, 5), 60, 40)
        };
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Activity.animationCount();
        }
    }
  
}