using System;

public class Word
{
    // Private variables to store the word and if it's hidden
    private string _text;
    private bool _isHidden;

    // Constructor to create a new word
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Start with word showing
    }

    // Method to hide this word
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to show this word (in case we want to unhide it later)
    public void Show()
    {
        _isHidden = false;
    }

    // Check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Get the display version of the word (either the word or underscores)
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Create underscores that match the word length
            string hiddenText = "";
            for (int i = 0; i < _text.Length; i++)
            {
                hiddenText += "_";
            }
            return hiddenText;
        }
        else
        {
            // Show the actual word
            return _text;
        }
    }
}
