using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        int number;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number:");
            number = int.Parse(Console.ReadLine());
            if(number != 0)
            {
                numbers.Add(number);
            }
        }while (number != 0);
        if(numbers.Count > 0)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            double average = (double)sum / numbers.Count;
            int max = numbers[0];
            foreach(int num in numbers)
            {
                if ( num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine("\nSum:" + sum);
            Console.WriteLine("Average:" + average);
            Console.WriteLine("Maximum:" + max);
        }
        else{
            Console.WriteLine("No numbers entered");
        }
        }
    }
