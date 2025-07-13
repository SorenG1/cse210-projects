using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new journal to store entries
        Journal myJournal = new Journal();
        bool running = true;

        // Keep showing the menu until user wants to quit
        while (running)
        {
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");

            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteEntry(myJournal);
                    break;
                case "2":
                    myJournal.Display();
                    break;
                case "3":
                    SaveJournal(myJournal);
                    break;
                case "4":
                    LoadJournal(myJournal);
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
            Console.WriteLine(); // Add a blank line before showing the menu again
        }
    }

    static void WriteEntry(Journal myJournal)
    {
        // Define prompts list
        var promptList = new string[]
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        // Pick a random prompt to show the user
        Random random = new Random();
        int index = random.Next(promptList.Length);
        string selectedPrompt = promptList[index];

        // Show the prompt and get user's response
        Console.WriteLine(selectedPrompt);
        string todayResponse = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString();

        // Create new entry and add it to the journal
        Entry newEntry = new Entry(selectedPrompt, todayResponse, date);
        myJournal.AddEntry(newEntry);
    }

    static void SaveJournal(Journal myJournal)
    {
        Console.Write("Enter filename to save to: ");
        string filename = Console.ReadLine();
        myJournal.Save(filename);
        Console.WriteLine("Journal saved.");
    }

    static void LoadJournal(Journal myJournal)
    {
        Console.Write("Enter filename to load from: ");
        string filename = Console.ReadLine();
        myJournal.Load(filename);
    }
}
