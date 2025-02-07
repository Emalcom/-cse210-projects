using System;
class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn from this experience?"
    };

    public ReflectionActivity() : base("Reflection", "This activity help you reflect on time when you showed strength and resilience.")
    {
    }

    public void Run()
    {
        StartActivity();

        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        animationCount();

        for (int i = 0; i < _duration / 5; i++)
        {
            Console.WriteLine(_questions[rand.Next(_questions.Count)]);
            animationCount();
        }
        EndActivity();

    }

}