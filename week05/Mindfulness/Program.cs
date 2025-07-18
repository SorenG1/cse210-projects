using System;

/*
CREATIVITY AND EXCEEDING REQUIREMENTS:
1. Added a counter to track how many times each activity has been performed during the session
2. Added a "View Session Stats" menu option to see activity usage
3. Enhanced the breathing activity with variable breath timing for more realistic breathing patterns
4. Added extra prompts and questions to the reflection and listing activities for more variety
5. Improved the user interface with clear formatting and better spacing
*/

class Program
{
    static void Main(string[] args)
    {
        // Track activity usage for this session
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        Console.WriteLine("Welcome to the Mindfulness Program!");
        
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity"); 
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. View session stats");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                reflectingCount++;
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                listingCount++;
            }
            else if (choice == "4")
            {
                // Show session statistics
                Console.Clear();
                Console.WriteLine("Session Statistics:");
                Console.WriteLine("===================");
                Console.WriteLine("Breathing activities completed: " + breathingCount);
                Console.WriteLine("Reflecting activities completed: " + reflectingCount);
                Console.WriteLine("Listing activities completed: " + listingCount);
                Console.WriteLine("Total activities completed: " + (breathingCount + reflectingCount + listingCount));
                Console.WriteLine();
                Console.WriteLine("Great job on your mindfulness practice!");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Thank you for using the Mindfulness Program!");
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid choice.");
            }
        }
    }
}