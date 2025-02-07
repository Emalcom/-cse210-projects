using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        while(true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();
            if (choice == "4") break;

            switch (choice)
            {
                case "1":
                new BreathingActivity().Run();
                break;
                case "2":
                new ReflectionActivity().Run();
                break;
                case "3":
                new ListingActivity().Run();
                break;
                default:
                Console.WriteLine("Invalid choice. Try again.");
                break;
            }
        }
    }
}