using System;
class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)

    {
        _name = name;
        _description = description;
        
    }
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"{_name} Activity");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        animationCount();
    }
    public void EndActivity()
    {
        Console.WriteLine("Well done! You have completed the activity.");
        Console.WriteLine($"You spent {_duration} seconds in the {_name} activity.");
        animationCount();
    }

    protected void animationCount()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime stratTime = DateTime.Now;
        DateTime endTime = stratTime.AddSeconds(10);

        int i = 0;
         
         while (DateTime.Now < endTime)
         {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }

         }
         Console.Write(" ");
    }
}