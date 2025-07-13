using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // List to store all the journal entries
    public List<Entry> _entries = new List<Entry>();

    // Add a new entry to the journal
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Show all entries by calling Display on each
    public void Display()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    // Save all entries to a file
    public void Save(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                // Save with a separator unlikely to show up in answers
                writer.WriteLine($"{e._entryDate}~|~{e._entryPrompt}~|~{e._entryResponse}");
            }
        }
    }

    // Load entries from a file, replacing any current entries
    public void Load(string filename)
    {
        _entries.Clear();

        if (!File.Exists(filename))
        {
            Console.WriteLine("Sorry, that file doesn't exist.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            if (parts.Length == 3)
            {
                Entry loadedEntry = new Entry(parts[1], parts[2], parts[0]);
                _entries.Add(loadedEntry);
            }
        }
    }
}
