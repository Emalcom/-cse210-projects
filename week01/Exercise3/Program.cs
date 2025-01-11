using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        /*bool playAgain = true;*/
        while(true)
        {
            Random random = new Random();
            int magicNumber = random.Next(1,101);
            int guess = -1;
            int guessCount = 0;
          while(guess != magicNumber)
          {
           Console.Write("What is your guess?");
           try
           {
             guess = int.Parse(Console.ReadLine());
             guessCount++;
          
             if (guess < magicNumber)
             {
              Console.WriteLine("Higher");
             }
            else if (guess > magicNumber)
            {
             Console.WriteLine("Lower");
            }
            else{
            Console.WriteLine($"You guessed it! it took you {guessCount}");
            }   
          }
          catch(FormatException)
          {
            Console.WriteLine("Please enter valid number.");
          }    
     }
     Console.WriteLine("Do you want to play again? (Yes/No)");
     String response = Console.ReadLine().Trim().ToLower();
     if(response != "yes")
     {
     break;
     Console.WriteLine("Thanks for playing! Goodbye.");
     }
   }
 }
}

