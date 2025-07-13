using System;

public class Reference
{
    // Private variables to store the scripture reference info
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // Constructor for a single verse like "John 3:16"
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

    // Constructor for multiple verses like "Proverbs 3:5-6"
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // Method to display the reference as a string
    public string GetDisplayText()
    {
        if (_startVerse == _endVerse)
        {
            // Single verse format
            return _book + " " + _chapter + ":" + _startVerse;
        }
        else
        {
            // Multiple verses format
            return _book + " " + _chapter + ":" + _startVerse + "-" + _endVerse;
        }
    }
}
