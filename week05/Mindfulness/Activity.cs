using System;
using System.Collections.Generic;
using System.Threading;


public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Display starting message and get duration from user
    public void DisplayStartingMessage()
    {
        Console.WriteLine("Welcome to the " + _name + ".");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
        
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    // Display ending message
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        
        Console.WriteLine();
        Console.WriteLine("You have completed another " + _duration + " seconds of the " + _name + ".");
        ShowSpinner(3);
    }

    // Show spinner animation
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    // Show countdown
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // Virtual method for running the activity
    public virtual void Run()
    {
        DisplayStartingMessage();
    }
}