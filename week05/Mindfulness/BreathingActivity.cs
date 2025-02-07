using System;
class BreathingActivity : Activity
{
    public BreathingActivity() : base ("Breathing","This activity helps you relax by guiding you through deep breathing.")
    {
    }
    public void Run()
    {
        StartActivity();

        for (int i = 0; i < _duration / 6; i++)
        {
            Console.WriteLine("Breathe in....");
            animationCount();
            Console.WriteLine("Breathe out...");
            animationCount();
        }
        EndActivity();
    }
} 