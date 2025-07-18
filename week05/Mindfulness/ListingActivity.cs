using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>();
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    // Run the listing activity
    public override void Run()
    {
        DisplayStartingMessage();
        
        Console.WriteLine("List as many responses you can to the following prompt:");
        
        // Get random prompt
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine("--- " + _prompts[index] + " ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        
        // Simple approach - just count items for the time period
        List<string> items = new List<string>();
        Console.WriteLine("Start listing items (press Enter after each item):");
        Console.WriteLine("Time's up when you reach " + _duration + " seconds!");
        
        // Simple timing - let user type for the duration
        for (int i = 0; i < _duration / 5; i++) // Assume 5 seconds per item
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (item != "")
            {
                items.Add(item);
            }
        }
        
        Console.WriteLine("You listed " + items.Count + " items!");
        Console.WriteLine();
        
        DisplayEndingMessage();
    }
}
