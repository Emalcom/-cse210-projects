
public abstract class Activity
{
    private DateTime activityDate;
    private int durationInMinutes;
    public Activity(DateTime date, int duration)
    {
        activityDate = date;
        durationInMinutes = duration;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public DateTime ActivityDate => activityDate;
    public int DurationInMinutes => durationInMinutes;

    public virtual string GetSummary()
    {
      return $"{ActivityDate:dd MMM yyy} {this.GetType().Name} ({DurationInMinutes} min): Distance {GetDistance()}, speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
      public static void animationCount()
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