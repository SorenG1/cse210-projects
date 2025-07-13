using System;

public class Entry
{
    // Member variables to store entry information
    public string _entryPrompt;
    public string _entryResponse;
    public string _entryDate;

    // Constructor
    public Entry(string prompt, string response, string date)
    {
        _entryPrompt = prompt;
        _entryResponse = response;
        _entryDate = date;
    }

    // Display the entry
    public void Display()
    {
        Console.WriteLine("=== My Journal Entry ===");
        Console.WriteLine("Date: " + _entryDate);
        Console.WriteLine("Prompt: " + _entryPrompt);
        Console.WriteLine("Answer: " + _entryResponse);
        Console.WriteLine();
    }
}
