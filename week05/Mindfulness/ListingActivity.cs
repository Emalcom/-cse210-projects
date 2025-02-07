using System;
class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity helps you reflect on the good things in your life.")
    {
    }

    public void Run()
    {
        StartActivity();

        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        animationCount();

        Console.WriteLine("Start listing items:");
        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while(DateTime.Now < endTime)
        {
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items!");
        EndActivity();
    }
}