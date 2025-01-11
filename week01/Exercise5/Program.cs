using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        String UserName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber();
        DisplayResult(userName, squaredNumber);
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static String PromptUserName()
    {
        Console.Write("Please enter your name:");
        return Console.ReadLine();
    }
    static int PromptUserNumber();
    {
         Console.Write("Please enter your favorite number:");
         return int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult (String userNames, int squaredNumber)
    {
        Console.WriteLine($"{userNames},the square of your number is {squaredNumber}");
    }
  }
}