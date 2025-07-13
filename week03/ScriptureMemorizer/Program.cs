using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a scripture to work with
        Reference scriptureRef = new Reference("Proverbs", 3, 5, 6);
        Scripture myScripture = new Scripture(scriptureRef, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        
        // Keep running until user quits or all words are hidden
        while (true)
        {
            // Clear the screen and show the current scripture
            Console.Clear();
            Console.WriteLine(myScripture.GetDisplayText());
            Console.WriteLine();

            // Check if all words are hidden - if so, we're done
            if (myScripture.IsCompletelyHidden())
            {
                break;
            }

            // Ask user what they want to do next
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string userChoice = Console.ReadLine();

            if (userChoice.ToLower() == "quit")
            {
                // User wants to quit the program
                break;
            }
            else
            {
                // Hide some random words from the scripture
                myScripture.HideRandomWords(3);
            }
        }
    }
}