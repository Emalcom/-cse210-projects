using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal journal = new Journal();
        String[] defaultprompts = {
            "who was the most interesting person I interacted with today?",
            "what was the best part of my day ?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        List<String> prompts = new List<String>(defaultprompts);
        Random random = new Random();

        while(true)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Add a new prompt");
            Console.WriteLine("6. Correct a response");
            Console.WriteLine("7. Delete an entry");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option: ");

            string choice =Console.ReadLine();
            switch (choice)
            {
                case "1":
                string prompt = prompts[random.Next(prompts.Count)];
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response:");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                journal.AddEntry(prompt, response, date);
                break;

                case "2":
                journal.DisplayJournal();
                break;

                case "3":
                Console.Write("Enter filename to save: ");
                string saveFilename = Console.ReadLine();
                journal.SaveToFile(saveFilename);
                break;

                case "4":
                Console.Write("Enter filename to load: ");
                String LoadFromFile = Console.ReadLine();
                journal.LoadFromFile(LoadFromFile);
                break;

                case "5":
                Console.Write("Enter a new prompt:");
                string newPrompt = Console.ReadLine();
                prompts.Add(newPrompt);
                Console.WriteLine("New prompt added successfully!");
                break;
                
                 case "6":
                 Console.WriteLine("Select an entry to edit:");
                 journal.DisplayJournalWithIndexes();
                 Console.Write("Enter the index of the entry: ");
                 if (int.TryParse(Console.ReadLine(),out int editIndex)&& journal.IsValidIndex(editIndex))
                 {
                  Console.Write("Enter the new response: ");
                  string newResponse = Console.ReadLine();
                  journal.EditResponse(editIndex, newResponse);
                  Console.WriteLine("Response updated successfully!");  
                 }
                 else{
                    Console.WriteLine("Invalid index!");
                 }
                 break;

                 case "7":
                 Console.WriteLine("Select an entry to delete:");
                 journal.DisplayJournalWithIndexes();
                 Console.Write("Enter the index of the entry: ");
                 if (int.TryParse(Console.ReadLine(),out int deleteIndex) && journal.IsValidIndex(deleteIndex))
                 {
                    journal.DeleteEntry(deleteIndex);
                    Console.WriteLine("Response deleted successfully!");
                 }
                 else{
                    Console.WriteLine("Invalid index!");
                 }
                 break;

                 case "8":
                 return;

                 default:
                 Console.WriteLine("Invalid Choice.Please try again.");
                 break;
                
            }
        }
    }
}