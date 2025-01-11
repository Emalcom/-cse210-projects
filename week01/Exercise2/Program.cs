using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("Enter your grade percentage (0-100):");
        int grade = int.Parse(Console.ReadLine());
        String letter;
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        String sign = "";
        int lastDigit = grade % 10;
        if (letter != "A" && letter != "F")
        {
            if(lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit >= 3)
            {
                sign = "-";
            }
        }
        else if( letter == "A" && grade < 93)
        {
            sign = "-";
        }
        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Unfortunately you didn't pass the course, keeping trying");
        }
    }
}