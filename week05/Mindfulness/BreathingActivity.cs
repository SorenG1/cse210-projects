using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    // Run the breathing activity
    public override void Run()
    {
        DisplayStartingMessage();
        
        // Simple way to count breaths for the duration
        int breathTime = 10; // Each breath cycle takes 10 seconds
        int totalBreaths = _duration / breathTime;
        
        for (int i = 0; i < totalBreaths; i++)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
            Console.WriteLine();
        }
        
        DisplayEndingMessage();
    }
}
